using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_de_Datos.Entidades
{
    public class Company
    {
        #region Propiedades Autoimplementadas
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(20)]
        public string PostalCode { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(250)]
        public string Photo { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Website { get; set; }
        #endregion
    }
}
