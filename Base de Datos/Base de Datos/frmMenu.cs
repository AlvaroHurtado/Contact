using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_Datos
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            var frmContact = new frmContact();
            frmContact.Show();
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            var frmMajor = new frmMajor();
            frmMajor.Show();
        }

        private void btnCoordinator_Click(object sender, EventArgs e)
        {
            var frmCoordinator = new frmCoordinator();
            frmCoordinator.Show();
        }

        private void btnAdviser_Click(object sender, EventArgs e)
        {
            var frmAdviser = new frmAdviser();
            frmAdviser.Show();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            var frmCompany = new frmCompany();
            frmCompany.Show();
        }

        private void btnCoach_Click(object sender, EventArgs e)
        {
            var frmCoach = new frmCoach();
            frmCoach.Show();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var frmStudent = new frmStudent();
            frmStudent.Show();

        }
    }
}
