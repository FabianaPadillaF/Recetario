using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recetario.Models
{
    public partial class Receta
    {
        [Key]
        public int RecetaId { get; set; }
        public string NombredeReceta { get; set; }
        public string Ingredientes { get; set; }
        public string Preparacion { get; set; }
        public string TiempodePreparacion { get; set; }
        public int Porciones { get; set; }
       
        //public int Imagen { get; set; }
    }
}
