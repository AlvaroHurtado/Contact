using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base_de_Datos.Entidades;

namespace Base_de_Datos
{
    public partial class frmStudent : MetroFramework.Forms.MetroForm
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                studentBindingSource.DataSource = dataContext.Students.ToList();
            }
            pnlStudent.Enabled = false;
            Student student = studentBindingSource.Current as Student; 
            if (student != null && student.Photo != null)
                pctPhoto.Image = Image.FromFile(student.Photo);
            else
                pctPhoto.Image = null;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            {
                pnlStudent.Enabled = true;
                pctPhoto.Image = null;
                studentBindingSource.Add(new Student());
                studentBindingSource.MoveLast();
                txtfirstName.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            {
                pnlStudent.Enabled = true;
                txtfirstName.Focus();
                Student student = studentBindingSource.Current as Student;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar al estudiante?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Student student = studentBindingSource.Current as Student;
                    if (student != null)
                    {
                        if (dataContext.Entry<Student>(student).State == EntityState.Detached)
                            dataContext.Set<Student>().Attach(student);
                        dataContext.Entry<Student>(student).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Eliminado");
                        studentBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlStudent.Enabled = false;
                    }
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Student student = studentBindingSource.Current as Student;
                if (student != null)
                {
                    if (dataContext.Entry<Student>(student).State == EntityState.Detached)
                        dataContext.Set<Student>().Attach(student);
                    if (student.Id == 0)
                        dataContext.Entry<Student>(student).State = EntityState.Added;
                    else
                        dataContext.Entry<Student>(student).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                    grdStudent.Refresh();
                    pnlStudent.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlStudent.Enabled = false;
            studentBindingSource.ResetBindings(false);
            frmStudent_Load(sender, e);
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
                    Student student = studentBindingSource.Current as Student;
                    if (student != null)
                        student.Photo = ofd.FileName;
                }
            }
        }

        private void grdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student = studentBindingSource.Current as Student;
            if (student != null && student.Photo != null)
                pctPhoto.Image = Image.FromFile(student.Photo);
            else
                pctPhoto.Image = null;
        }
    }
}
