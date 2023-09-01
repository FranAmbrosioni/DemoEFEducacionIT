using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEFWindows.Models
{
    [Table("Producto")]
    public class Producto
    {
        
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "money")]
       
        public decimal? Precio { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(300)]
        
        public string Descripcion { get; set; }

        public int CategoriaId { get; set; }

        #region propiedades de navegacion

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        #endregion 
    }
}
