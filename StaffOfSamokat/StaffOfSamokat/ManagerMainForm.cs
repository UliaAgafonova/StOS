using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StaffOfSamokat
{
    public partial class ManagerMainForm : Form
    {
        Database db = new Database(); //подключение к бд
        int selectedRow;
        public ManagerMainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }
        private void ManagerMainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            SelectRow(ResumeDataGridView);
        }
        private void CreateColumns()
        {
            ResumeDataGridView.Columns.Add("ID_Resume", "ID_Resume");
            ResumeDataGridView.Columns["ID_Resume"].Visible = false;
            ResumeDataGridView.Columns.Add("First_Name", "Имя");
            ResumeDataGridView.Columns["First_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("Last_Name", "Фамилия");
            ResumeDataGridView.Columns["Last_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("Patronymic", "Отчество");
            ResumeDataGridView.Columns["Patronymic"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("Date_Of_Birth", "Дата рождения");
            ResumeDataGridView.Columns["Date_Of_Birth"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("Phone_Number", "Номер телефона");
            ResumeDataGridView.Columns["Phone_Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("Post", "Должность");
            ResumeDataGridView.Columns["Post"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("City", "Город");
            ResumeDataGridView.Columns["City"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("CFZ", "ЦФЗ");
            ResumeDataGridView.Columns["CFZ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns.Add("Experience", "Опыт работы");
            ResumeDataGridView.Columns["Experience"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ResumeDataGridView.Columns["Experience"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ResumeDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            ResumeDataGridView.Columns.Add("Status", "Статус");
            ResumeDataGridView.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void ReadRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                record.GetDateTime(4).ToString("yyyy-MM-dd"), record.GetInt64(5), record.GetString(6),
                record.GetString(7), record.GetString(8), record.GetString(9), record.GetString(10));
        }
        private void SelectRow(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"select ID_Resume, First_Name, Last_Name, Patronymic, Date_Of_Birth, Phone_Number," +
                $" Post.Name as Post, City.Name as City, CFZ.Address as CFZ,Experience, Status.Name as Status" +
                $" from Resume join Post on Post = ID_Post join City on City = ID_City join" +
                $" CFZ on CFZ = ID_CFZ join Status on Status = ID_Status"; //выбока всех резюме
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            db.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadRow(dgv, reader);
            }
            reader.Close();
        }
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchQuery = $"select ID_Resume, First_Name, Last_Name, Patronymic, Date_Of_Birth, Phone_Number," +
                $" Post.Name as Post, City.Name as City, CFZ.Address as CFZ,Experience, Status.Name as Status" +
                $" from Resume join Post on Resume.Post = Post.ID_Post join City on Resume.City = City.ID_City join" +
                $" CFZ on Resume.CFZ = CFZ.ID_CFZ join Status on Resume.Status = Status.ID_Status where concat (First_Name," +
                $" Last_Name, Patronymic, convert(varchar, Date_Of_Birth, 102), convert(varchar, Phone_Number), Post.Name, City.Name, CFZ.Address," +
                $" Experience, Status.Name) like '%" + SearchTextBox.Text + "%'"; //выбока определенных резюме
            SqlCommand command = new SqlCommand(searchQuery, db.GetConnection());
            db.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadRow(dgv,reader);
            }
            reader.Close();
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(ResumeDataGridView);
        }
        private void ConsiderationButton_Click(object sender, EventArgs e)
        {
            int rowIndex = ResumeDataGridView.CurrentRow.Index;
            string idResume = ResumeDataGridView.Rows[rowIndex].Cells["ID_Resume"].Value.ToString();
            string firstName = ResumeDataGridView.Rows[rowIndex].Cells["First_Name"].Value.ToString();
            string lastName = ResumeDataGridView.Rows[rowIndex].Cells["Last_Name"].Value.ToString();
            string patronymic = ResumeDataGridView.Rows[rowIndex].Cells["Patronymic"].Value.ToString();
            string post = ResumeDataGridView.Rows[rowIndex].Cells["Post"].Value.ToString();
            string phoneNumber = ResumeDataGridView.Rows[rowIndex].Cells["Phone_number"].Value.ToString();
            string status = ResumeDataGridView.Rows[rowIndex].Cells["Status"].Value.ToString();
            if (status=="На рассмотрении")
            {
                MessageBox.Show("Резюме уже отправлено на рассмотрение!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $"update Resume set Status = 2 where ID_Resume = {idResume}";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                db.OpenConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
                SelectRow(ResumeDataGridView);
                MessageBox.Show($"Резюме соискателя {firstName} {lastName} {patronymic} на должность {post} на рассмотрении.\n" +
                    $"Соискатель уведомлен о вашем решении.\n" +
                    $"Обратитесь по номеру соискателя {phoneNumber}.", "Резюме отправлено на рассмотрение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AsseptButton_Click(object sender, EventArgs e)
        {
            int rowIndex = ResumeDataGridView.CurrentRow.Index;
            string idResume = ResumeDataGridView.Rows[rowIndex].Cells["ID_Resume"].Value.ToString();
            string firstName = ResumeDataGridView.Rows[rowIndex].Cells["First_Name"].Value.ToString();
            string lastName = ResumeDataGridView.Rows[rowIndex].Cells["Last_Name"].Value.ToString();
            string patronymic = ResumeDataGridView.Rows[rowIndex].Cells["Patronymic"].Value.ToString();
            string post = ResumeDataGridView.Rows[rowIndex].Cells["Post"].Value.ToString();
            string status = ResumeDataGridView.Rows[rowIndex].Cells["Status"].Value.ToString();
            if (status == "Принято")
            {
                MessageBox.Show("Резюме уже принято!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $"update Resume set Status = 3 where ID_Resume = {idResume}";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                db.OpenConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
                SelectRow(ResumeDataGridView);
                MessageBox.Show($"Вы приняли соискателя {firstName} {lastName} {patronymic} на должность {post}.",
                    "Соискатель принят!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            int rowIndex = ResumeDataGridView.CurrentRow.Index;
            string idResume = ResumeDataGridView.Rows[rowIndex].Cells["ID_Resume"].Value.ToString();
            string firstName = ResumeDataGridView.Rows[rowIndex].Cells["First_Name"].Value.ToString();
            string lastName = ResumeDataGridView.Rows[rowIndex].Cells["Last_Name"].Value.ToString();
            string patronymic = ResumeDataGridView.Rows[rowIndex].Cells["Patronymic"].Value.ToString();
            string post = ResumeDataGridView.Rows[rowIndex].Cells["Post"].Value.ToString();
            string status = ResumeDataGridView.Rows[rowIndex].Cells["Status"].Value.ToString();
            if (status == "Отклонено")
            {
                MessageBox.Show("Резюме уже отклонено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $"update Resume set Status = 4 where ID_Resume = {idResume}";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                db.OpenConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
                SelectRow(ResumeDataGridView);
                MessageBox.Show($"Вы отклонили резюме соискателя {firstName} {lastName} {patronymic} на должность {post}.\n" +
                    $"Соискатель уведомлен о вашем решении.", "Резюме отклонено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
