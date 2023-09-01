using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEFWindows.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public int Id { get; set; }

        [DataType("nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Apellido { get; set; }
        [DataType("nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [DataType("nvarchar")]
        [MaxLength(50)]
        [Required]
        public string Ciudad { get; set; }

    }
}
