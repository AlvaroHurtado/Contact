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
    public partial class frmContact : MetroFramework.Forms.MetroForm
    {
        public frmContact()
        {
            InitializeComponent();
        }
        private void frmContact_Load(object sender, System.EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                contactBindingSource.DataSource = dataContext.Contacts.ToList();
            }
            pnlContact.Enabled = false;
            Contact contact = contactBindingSource.Current as Contact;
            if (contact != null && contact.Photo != null)
                pctPhoto.Image = Image.FromFile(contact.Photo);
            else
                pctPhoto.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlContact.Enabled = true;
            pctPhoto.Image = null;
            contactBindingSource.Add(new Contact());
            contactBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlContact.Enabled = true;
            txtFirstName.Focus();
            Contact contact = contactBindingSource.Current as Contact;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlContact.Enabled = false;
            contactBindingSource.ResetBindings(false);
            frmContact_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar al Contacto?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Contact contact = contactBindingSource.Current as Contact; ;
                    if (contact != null)
                    {
                        if (dataContext.Entry<Contact>(contact).State == EntityState.Detached)
                            dataContext.Set<Contact>().Attach(contact);
                        dataContext.Entry<Contact>(contact).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Eliminado");
                        contactBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlContact.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Contact contact = contactBindingSource.Current as Contact; ;
                if (contact != null)
                {
                    if (dataContext.Entry<Contact>(contact).State == EntityState.Detached)
                        dataContext.Set<Contact>().Attach(contact);
                    if (contact.Id == 0)
                        dataContext.Entry<Contact>(contact).State = EntityState.Added;
                    else
                        dataContext.Entry<Contact>(contact).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                    grdContact.Refresh();
                    pnlContact.Enabled = false;
                }

            }
        }

        private void grdMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Contact contact = contactBindingSource.Current as Contact;
            if (contact != null && contact.Photo != null)
                pctPhoto.Image = Image.FromFile(contact.Photo);
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
                    Contact contact = contactBindingSource.Current as Contact;
                    if (contact != null)
                        contact.Photo = ofd.FileName;
                }
            }

        }
    }

}
