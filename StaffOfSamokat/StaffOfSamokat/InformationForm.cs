using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffOfSamokat
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            UserMainForm userMainForm = new UserMainForm();
            this.Close();
            userMainForm.Show(); //переход к главной форме пользователя
        }
    }
}
