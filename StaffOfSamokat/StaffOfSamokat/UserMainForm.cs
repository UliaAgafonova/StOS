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
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            ResumeForm resumeForm = new ResumeForm();
            this.Close();
            resumeForm.Show(); //переход к форме резюме
        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            this.Close();
            informationForm.Show(); //переход к форме информации
        }
    }
}
