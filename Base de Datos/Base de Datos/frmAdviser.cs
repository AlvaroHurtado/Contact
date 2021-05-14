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
    public partial class frmAdviser : MetroFramework.Forms.MetroForm
    {
        public frmAdviser()
        {
            InitializeComponent();
        }
        private void frmAdviser_Load(object sender, System.EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                adviserBindingSource.DataSource = dataContext.advisers.ToList();
            }
            pnlAdviser.Enabled = false;
            Adviser adviser = adviserBindingSource.Current as Adviser;
            if (adviser != null && adviser.Photo != null)
                pctPhoto.Image = Image.FromFile(adviser.Photo);
            else
                pctPhoto.Image = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdviser.Enabled = true;
            pctPhoto.Image = null;
            adviserBindingSource.Add(new Adviser());
            adviserBindingSource.MoveLast();
            txtFirstName.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlAdviser.Enabled = true;
            txtFirstName.Focus();
            Adviser adviser = adviserBindingSource.Current as Adviser;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdviser.Enabled = false;
            adviserBindingSource.ResetBindings(false);
            frmAdviser_Load(sender, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar el Anunciante?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Adviser adviser = adviserBindingSource.Current as Adviser;
                    if (adviser != null)
                    {
                        if (dataContext.Entry<Adviser>(adviser).State == EntityState.Detached)
                            dataContext.Set<Adviser>().Attach(adviser);
                        dataContext.Entry<Adviser>(adviser).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Eliminado");
                        adviserBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlAdviser.Enabled = false;
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Adviser adviser = adviserBindingSource.Current as Adviser;
                if (adviser != null)
                {
                    if (dataContext.Entry<Adviser>(adviser).State == EntityState.Detached)
                        dataContext.Set<Adviser>().Attach(adviser);
                    if (adviser.Id == 0)
                        dataContext.Entry<Adviser>(adviser).State = EntityState.Added;
                    else
                        dataContext.Entry<Adviser>(adviser).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                    grdAdviser.Refresh();
                    pnlAdviser.Enabled = false;
                }
            }
        }

        private void grdAdviser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Adviser adviser = adviserBindingSource.Current as Adviser;
            if (adviser != null && adviser.Photo != null)
                pctPhoto.Image = Image.FromFile(adviser.Photo);
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
                    Adviser adviser = adviserBindingSource.Current as Adviser;
                    if (adviser != null)
                        adviser.Photo = ofd.FileName;
                }
            }
        }
    }
}
