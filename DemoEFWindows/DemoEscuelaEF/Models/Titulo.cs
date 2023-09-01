using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEscuelaEF.Models
{

    [Table("Titulo")]
    public class Titulo
    {
        public int Id { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        public List<Profesor> profesores { get; set; }
    }
}
