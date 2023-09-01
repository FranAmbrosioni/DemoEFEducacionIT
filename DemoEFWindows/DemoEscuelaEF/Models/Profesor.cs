using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEscuelaEF.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int TituloId { get; set; }
        //Navegacion 
        [ForeignKey("TituloId")]
        public Titulo Titulo { get; set; }

    }
}
