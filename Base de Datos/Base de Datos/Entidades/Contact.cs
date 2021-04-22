using System.ComponentModel.DataAnnotations;

namespace Base_de_Datos.Entidades
{
    public class Contact
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
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string CellphoneNumber { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Department { get; set; }
        #endregion
    }
}
