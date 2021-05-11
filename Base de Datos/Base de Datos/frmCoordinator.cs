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
    public partial class frmCoordinator : MetroFramework.Forms.MetroForm
    {
        public frmCoordinator()
        {
            InitializeComponent();
        }
        private void frmCoordinator_Load(object sender, System.EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                coordinatorBindingSource.DataSource = dataContext.Coordinators.ToList();
            }
            pnlCoordinator.Enabled = false;
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.Photo != null)
                pctPhoto.Image = Image.FromFile(coordinator.Photo);
            else
                pctPhoto.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlCoordinator.Enabled = true;
            pctPhoto.Image = null;
            coordinatorBindingSource.Add(new Coordinator());
            coordinatorBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlCoordinator.Enabled = true;
            txtFirstName.Focus();
            Coordinator coordinator= coordinatorBindingSource.Current as Coordinator;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCoordinator.Enabled = false;
            coordinatorBindingSource.ResetBindings(false);
            frmCoordinator_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar al Coordinador?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                    if (coordinator != null)
                    {
                        if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                            dataContext.Set<Coordinator>().Attach(coordinator);
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Eliminado");
                        coordinatorBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlCoordinator.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                if (coordinator != null)
                {
                    if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                        dataContext.Set<Coordinator>().Attach(coordinator);
                    if (coordinator.Id == 0)
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Added;
                    else
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                    grdCoordinator.Refresh();
                    pnlCoordinator.Enabled = false;
                }

            }
        }

        private void grdCoordinator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.Photo != null)
                pctPhoto.Image = Image.FromFile(coordinator.Photo);
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
                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                    if (coordinator != null)
                        coordinator.Photo = ofd.FileName;
                }
            }

        }
    }
}
