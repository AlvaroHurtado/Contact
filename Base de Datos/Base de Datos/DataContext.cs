using Base_de_Datos.Entidades;
using System.Data.Entity;

namespace Base_de_Datos
{
    public class DataContext:DbContext
    {
        public DbSet <Contact> Contacts { get; set; }
        public DataContext() : base("name=miConexion") 
        { 
        }
    }
}
