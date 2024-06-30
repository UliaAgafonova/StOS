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
    public partial class AuthorizationForm : Form
    {
        Database db = new Database(); //подключение к бд
        public AuthorizationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }
        public static int ID_User { get; set; }
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*'; //скрытие пароля символом
        }
        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select * from [User] where Login ='{login}' and Password ='{password}'"; //выборка данных из таблицы Пользователь
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1) //проверка наличия такого пользователя
            {
                MessageBox.Show("Вы успешно вошли!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (login=="m" & password == "m")
                {
                    ManagerMainForm managerMainForm = new ManagerMainForm();
                    managerMainForm.Show(); //переход к главной форме для менеджера
                    this.Hide();
                }
                else
                {
                    db.OpenConnection();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read()) //вывод данных вакансии
                    {
                        AuthorizationForm.ID_User = (int)dataReader["ID_User"];
                    }
                    db.CloseConnection();
                    UserMainForm userMainForm = new UserMainForm();
                    userMainForm.Show(); //переход к главной форме для пользователя
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm= new RegistrationForm();
            registrationForm.Show(); //переход к форме регистрации
            this.Hide();
        }
    }
}
