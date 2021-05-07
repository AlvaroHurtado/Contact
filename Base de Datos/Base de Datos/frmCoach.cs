using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Base_de_Datos.Entidades;

namespace Base_de_Datos
{
    public partial class frmCoach : MetroFramework.Forms.MetroForm
    {
        public frmCoach()
        {
            InitializeComponent();
        }

        private void frmCoach_Load(object sender, System.EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                coachBindingSource.DataSource = dataContext.Contacts.ToList();
            }
            pnlCoach.Enabled = false;
            Contact contact = coachBindingSource.Current as Contact;
            if (contact != null && contact.Photo != null)
                pctPhoto.Image = Image.FromFile(contact.Photo);
            else
                pctPhoto.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlCoach.Enabled = true;
            pctPhoto.Image = null;
            coachBindingSource.Add(new Coach());
            coachBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlCoach.Enabled = true;
            txtFirstName.Focus();
            Coach coach = coachBindingSource.Current as Coach;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCoach.Enabled = false;
            coachBindingSource.ResetBindings(false);
            frmCoach_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar al coach?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                    {
                        if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                            dataContext.Set<Coach>().Attach(coach);
                        dataContext.Entry<Coach>(coach).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Eliminado");
                        coachBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlCoach.Enabled = false;
                    }
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Coach coach = coachBindingSource.Current as Coach;
                if (coach != null)
                {
                    if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                        dataContext.Set<Coach>().Attach(coach);
                    if (coach.Id == 0)
                        dataContext.Entry<Coach>(coach).State = EntityState.Added;
                    else
                        dataContext.Entry<Coach>(coach).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                    grdCoach.Refresh();
                    pnlCoach.Enabled = false;
                }

            }
        }

        private void grdCoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Coach coach = coachBindingSource.Current as Coach;
            if (coach != null && coach.Photo != null)
                pctPhoto.Image = Image.FromFile(coach.Photo);
            else
                pctPhoto.Image = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "archivos JPG|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctPhoto.Image = Image.FromFile(ofd.FileName);
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                        coach.Photo = ofd.FileName;
                }
            }

        }
    }
}
