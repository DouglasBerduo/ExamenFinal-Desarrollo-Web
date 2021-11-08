using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class MateriasModel
    {
      [Key]
      public int IDMateria { get; set; }
      public string NombreMateria { get; set; }


    }
}
