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
    public partial class RegistrationForm : Form
    {
        Database db = new Database(); //подключение к бд
        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }
        private Boolean Check() //метод, проверяющий чтобы все поля были заполнены
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean Repeat() //метод, проверяющий повторение пользователей
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select * from [User] where Login='{login}' and Password='{password}'"; //выбока данных из таблицы Пользователь
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0) //проверка наличия такого пользователя
            {
                MessageBox.Show("Такой пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (Check()) //активация метода проверки пустых полей
            {
                return;
            }
            if (Repeat()) //активация метода проверки повторения пользователей
            {
                return;
            }
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            string query = $"insert into [User] (Login, Password) values ('{login}','{password}')"; //занесение пользователя в базу данных
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AuthorizationForm authorizationForm = new AuthorizationForm();
                this.Close();
                authorizationForm.Show(); //переход к форме авторизации
            }
            else
                MessageBox.Show("Такой аккаунт не может быть создан", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }

        private void AuthorizationLabel_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            this.Close();
            authorizationForm.Show(); //переход к форме авторизации
        }
    }
}
