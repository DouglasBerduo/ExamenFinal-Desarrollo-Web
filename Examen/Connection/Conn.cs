using Examen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Connection
{
    public class Conn : DbContext
    {
        public Conn(DbContextOptions<Conn> options):base(options)
        {

        }

        public DbSet<AlumnosModel> Tbl_Alumnos { get; set; }
        public DbSet<MateriasModel> Tbl_Materias { get; set; }
        public DbSet<NotasModel> Tbl_Notas { get; set; }

    }
}
