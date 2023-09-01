using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFWindows.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        //table porque estoy arriba de la clase
        //seteo nombre tabla y schema dbo
        //schema nombre logico para agrupar modelos 
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]// evita not null en db
        public string Nombre { get; set; }

        #region propiedades de navegacion

        public List<Producto> Productos { get; set; }


        #endregion

    }
}
