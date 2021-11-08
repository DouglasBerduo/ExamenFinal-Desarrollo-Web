using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class NotasModel
    {
      [Key]
      public int IDNota { get; set; }
      public int? IDAlumno { get; set; }
      [ForeignKey("IDAlumno")]
      //public virtual AlumnosModel Alumno { get; set; }

      public int? IDMateria { get; set; }
        [ForeignKey("IDMateria")]
      //  public virtual MateriasModel Materia { get; set; }

        public int Nota { get; set; }
    
        public string resultado { get; set; }
    }
}
