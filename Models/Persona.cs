using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCOREM3_CodeFirst.Models
{
    public class Persona
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="NOM.COMPLETO")]
        [Required(ErrorMessage ="El NOMBRE COMPLETO es un campo obligatorio")]
        [Column(TypeName="nvarchar(80)")]
        public string nombreCompleto { get; set; }
        [Display(Name = "FEC.NACIMIENTO")]
        [Column(TypeName = "datetime")]
        [DataType(DataType.Date)]
        public DateTime fechaNacimiento { get; set; }
        [Display(Name = "CORREO")]
        [Column(TypeName = "nvarchar(50)")]
        [DataType(DataType.EmailAddress)]
        public string correoElectronico { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "RESIDENCIA")]
        public string direccion { get; set; }
    }
}
