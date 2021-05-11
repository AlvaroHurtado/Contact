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
    public partial class frmMajor : MetroFramework.Forms.MetroForm
    {
        public frmMajor()
        {
            InitializeComponent();
        }
        private void frmMajor_Load(object sender, System.EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                majorBindingSource.DataSource = dataContext.Majors.ToList();
            }
            pnlMajor.Enabled = false;
            Major major = majorBindingSource.Current as Major;
            if (major != null && major.Photo != null)
                pctPhoto.Image = Image.FromFile(major.Photo);
            else
                pctPhoto.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlMajor.Enabled = true;
            pctPhoto.Image = null;
            majorBindingSource.Add(new Major());
            majorBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlMajor.Enabled = true;
            txtFirstName.Focus();
            Major major = majorBindingSource.Current as Major;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlMajor.Enabled = false;
            majorBindingSource.ResetBindings(false);
            frmMajor_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar al Director?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Major major = majorBindingSource.Current as Major;
                    if (major != null)
                    {
                        if (dataContext.Entry<Major>(major).State == EntityState.Detached)
                            dataContext.Set<Major>().Attach(major);
                        dataContext.Entry<Major>(major).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Eliminado");
                        majorBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlMajor.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Major major = majorBindingSource.Current as Major;
                if (major != null)
                {
                    if (dataContext.Entry<Major>(major).State == EntityState.Detached)
                        dataContext.Set<Major>().Attach(major);
                    if (major.Id == 0)
                        dataContext.Entry<Major>(major).State = EntityState.Added;
                    else
                        dataContext.Entry<Major>(major).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                    grdMajor.Refresh();
                    pnlMajor.Enabled = false;
                }

            }
        }

        private void grdMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Major major = majorBindingSource.Current as Major;
            if (major != null && major.Photo != null)
                pctPhoto.Image = Image.FromFile(major.Photo);
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
                    Major major = majorBindingSource.Current as Major;
                    if (major != null)
                        major.Photo = ofd.FileName;
                }
            }

        }
    }
}
