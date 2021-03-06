using Base_de_Datos.Entidades;
using System.Data.Entity;

namespace Base_de_Datos
{
    public class DataContext:DbContext
    {
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Student> Students { get; set; }
        public DbSet <Coach> Coaches { get; set; }
        public DbSet <Major> Majors { get; set; }
        public DbSet <Coordinator> Coordinators { get; set; }
        public DbSet <Adviser> advisers { get; set; }
        public DbSet <Company> companies { get; set; }
        public DataContext() : base("name=miConexion") 
        { 
        }
    }
}
