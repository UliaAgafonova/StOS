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
using System.Xml;
using System.Xml.Linq;
using System.Net;

namespace StaffOfSamokat
{
    public partial class ResumeForm : Form
    {
        Database db = new Database(); //подключение к бд
        public ResumeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
            bool hasResume = Presence();  //активация метода проверки наличия резюме у пользователя

            string vacancyQuery = $"select name from Post"; //выбока вакансий
            SqlCommand vacancyCommand = new SqlCommand(vacancyQuery, db.GetConnection());
            db.OpenConnection();
            SqlDataReader vacancyDataReader = vacancyCommand.ExecuteReader();
            while (vacancyDataReader.Read()) //заполнение PostComboBox данными из запроса
            {
                string post = vacancyDataReader["Name"].ToString();
                PostComboBox.Items.Add(post);
            }
            db.CloseConnection();

            string cityQuery = $"select name from City"; //выбока городов
            SqlCommand cityCommand = new SqlCommand(cityQuery, db.GetConnection());
            db.OpenConnection();
            SqlDataReader cityDataReader = cityCommand.ExecuteReader();
            while (cityDataReader.Read()) //заполнение CityComboBox данными из запроса
            {
                string city = cityDataReader["Name"].ToString();
                CityComboBox.Items.Add(city);
            }
            db.CloseConnection();
        }
        private void ReplaceButton(Button oldResumeButton, Button newResumeButton) //метод, изменяющий кнопку
        {
            Control parent = oldResumeButton.Parent;
            parent.Controls.Remove(oldResumeButton);
            parent.Controls.Add(newResumeButton);
            newResumeButton.Location = oldResumeButton.Location;
            newResumeButton.Size = oldResumeButton.Size;
            newResumeButton.Anchor = oldResumeButton.Anchor;
            newResumeButton.Font = oldResumeButton.Font; 
            newResumeButton.BackColor = oldResumeButton.BackColor; 
            newResumeButton.ForeColor = oldResumeButton.ForeColor; 
            newResumeButton.FlatStyle = oldResumeButton.FlatStyle;
            newResumeButton.Text = "Изменить резюме";
        }
        private Boolean Presence() //метод, проверяющий наличие резюме у пользователя
        {
            int userId = AuthorizationForm.ID_User;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select ID_Resume, First_Name, Last_Name, Patronymic, Date_Of_Birth, Phone_Number," +
                $" Post.Name as Post, City.Name as City, CFZ.Address as CFZ,Experience, Status.Name as Status, ID_User" +
                $" from Resume join Post on Post = ID_Post join City on City = ID_City join" +
                $" CFZ on CFZ = ID_CFZ join Status on Status = ID_Status where ID_User='{userId}'"; //выбока резюме определенного пользователя
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0) //проверка наличия резюме у пользователя
            {
                db.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read()) //вывод данных резюме
                {
                    FirstNameTextBox.Text = dataReader[1].ToString();
                    LastNameTextBox.Text = dataReader[2].ToString();
                    PatronymicTextBox.Text = dataReader[3].ToString();
                    DateOfBirthTextBox.Text = DateTime.Parse(dataReader[4].ToString()).ToString("yyyy-MM-dd"); ;
                    PhoneNumberTextBox.Text = dataReader[5].ToString();
                    PostComboBox.Text = dataReader[6].ToString();
                    CityComboBox.Text = dataReader[7].ToString();
                    CFZComboBox.Text = dataReader[8].ToString();
                    ExperienceTextBox.Text = dataReader[9].ToString();
                    string status = dataReader[10].ToString();
                    StatusLabel.Text = $"Статус\nвашего\nрезюме\n{status}!";
                    Button ChangeResumeButton = new Button();
                    ReplaceButton(AddResumeButton, ChangeResumeButton);
                    ChangeResumeButton.Click += ChangeResumeButton_Click;
                }
                db.CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CFZComboBox.Items.Clear();
            string cityUser = CityComboBox.SelectedItem.ToString();
            string CFZQuery = $"select CFZ.Address from CFZ join City on CFZ.City=City.ID_City where" +
                $" City.Name='{cityUser}'"; //выбока ЦФЗ в выбранном городе
            SqlCommand CFZCommand = new SqlCommand(CFZQuery, db.GetConnection());
            db.OpenConnection();
            SqlDataReader CFZDataReader = CFZCommand.ExecuteReader();
            while (CFZDataReader.Read()) //заполнение PostComboBox данными из запроса
            {
                string CFZ = CFZDataReader["Address"].ToString();
                CFZComboBox.Items.Add(CFZ);
            }
            db.CloseConnection();
        }
        private Boolean Check() //метод, проверяющий чтобы все обязательные поля были заполнены
        {
            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var patronymic = PatronymicTextBox.Text;
            var dateOfBirth = DateOfBirthTextBox.Text;
            var phoneNumber = PhoneNumberTextBox.Text;
            var post = PostComboBox.Text;
            var city = CityComboBox.Text;
            var CFZ = CFZComboBox.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(patronymic)
                || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(post)
                || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(CFZ))
            {
                MessageBox.Show("Вы заполнили не все обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void AddResumeButton_Click(object sender, EventArgs e)
        {
            if (Check()) //активация метода проверки пустых полей
            {
                return;
            }
            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var patronymic = PatronymicTextBox.Text;
            var dateOfBirth = DateOfBirthTextBox.Text;
            var phoneNumber = PhoneNumberTextBox.Text;
            var post = PostComboBox.SelectedItem.ToString();
            var city = CityComboBox.SelectedItem.ToString();
            var CFZ = CFZComboBox.SelectedItem.ToString();
            var experience = ExperienceTextBox.Text;
            int userId = AuthorizationForm.ID_User;
            string query = $"insert into Resume (First_Name, Last_Name, Patronymic, Date_Of_Birth," +
                $" Phone_Number, Post, City, CFZ, Experience, Status, ID_User) " +
                $"select '{firstName}','{lastName}','{patronymic}', '{dateOfBirth}', '{phoneNumber}'," +
                $"post.ID_Post, city.ID_City, cfz.ID_CFZ, '{experience}', 1, '{userId}'" +
                $"from Post post join City city on 1=1 join CFZ cfz on 1=1" +
                $"where post.Name = '{post}' and city.Name = '{city}' and cfz.Address = '{CFZ}'"; // занесение заполненного резюме в базу данных
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные сохранены!\nВаше резюме опубликовано.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.CloseConnection();
        }
        private void ChangeResumeButton_Click(object sender, EventArgs e)
        {
            if (Check()) //активация метода проверки пустых полей
            {
                return;
            }
            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var patronymic = PatronymicTextBox.Text;
            var dateOfBirth = DateOfBirthTextBox.Text;
            var phoneNumber = PhoneNumberTextBox.Text;
            var post = PostComboBox.Text;
            var city = CityComboBox.Text;
            var CFZ = CFZComboBox.Text;
            var experience = ExperienceTextBox.Text;
            int userId = AuthorizationForm.ID_User;
            string query = $"update Resume set First_Name = '{firstName}', Last_Name = '{lastName}'," +
                $"Patronymic = '{patronymic}', Date_Of_Birth = '{dateOfBirth}',Phone_Number = '{phoneNumber}'," +
                $" Post = (select ID_Post from Post where Name = '{post}'), " +
                $"City = (select ID_City from City where Name = '{city}'), " +
                $"CFZ = (select ID_CFZ from CFZ where Address = '{CFZ}'), Experience = '{experience}' " +
                $"where ID_User = '{userId}'"; // изменение резюме пользователя
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Данные вашего резюме изменены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.CloseConnection();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            UserMainForm userMainForm = new UserMainForm();
            this.Close();
            userMainForm.Show(); //переход к главной форме пользователя
        }
    }
}
