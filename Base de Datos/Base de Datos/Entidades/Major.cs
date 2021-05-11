using System.ComponentModel.DataAnnotations;

namespace Base_de_Datos.Entidades
{
    public class Major
    {
        #region Propiedades Autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(20)]
        public string CellNumber { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        #endregion
    }
}
