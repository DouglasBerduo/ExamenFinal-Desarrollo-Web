using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class AlumnosModel
    {
        [Key]
        public int IDAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Estado { get; set; }

    }
}
