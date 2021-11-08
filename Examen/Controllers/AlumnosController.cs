using Examen.Connection;
using Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;


namespace Examen.Controllers
{
    

    [Route("api/[controller]")]
[ApiController]
public class AlumnosController : ControllerBase
{
    private readonly Conn _context;
    public AlumnosController(Conn contexto)
    {
        _context = contexto;
    }







        //Traer todos los registros
        [HttpGet]
    public async Task<ActionResult<IEnumerable<AlumnosModel>>> GetAlumnoItems()
    {
        return await _context.Tbl_Alumnos.ToListAsync();
    }


    //Insert
    [HttpPost]
    public async Task<ActionResult<AlumnosModel>> PostAlumno(AlumnosModel item)

    {
        _context.Tbl_Alumnos.Add(item);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAlumnoItems), new { id = item.IDAlumno }, item);
    }


    //Update
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAlumnoItem(int id, AlumnosModel item)
    {
        if (id != item.IDAlumno)
        {
            return BadRequest();

        }
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    //Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAlumno(int id)
    {
        var alumnoitem = await _context.Tbl_Alumnos.FindAsync(id);
        if (alumnoitem == null)
        {
            return NotFound();

        }

        _context.Tbl_Alumnos.Remove(alumnoitem);
        await _context.SaveChangesAsync();

        return NoContent();
    }

        //Get Parametro id
    //    [HttpGet("{id}")]
     //   public async Task<ActionResult<AlumnosModel>> GetAlumnoEstado(int Estado)
    //    {
    /////        var alumnoItem = await _context.Tbl_Alumnos.FindAsync(Estado);
     //       if (alumnoItem == null)
     //       {
//
      //          return NotFound();
     //       }
/////////////return alumnoItem; 

     //   }

        [HttpGet("{buscar}/{estado}")]
        public async Task<IEnumerable<AlumnosModel>> Estado(string estado)
        {
            IQueryable<AlumnosModel> query = _context.Tbl_Alumnos;
            if (!string.IsNullOrEmpty(estado))
            {
                query = query.Where(e => e.Estado.Contains(estado));


            }
            return await query.ToListAsync();

        }

     



    }
}