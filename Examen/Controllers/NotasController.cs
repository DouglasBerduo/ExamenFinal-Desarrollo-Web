using Examen.Connection;
using Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly Conn _context;
        public NotasController(Conn contexto)
        {
            _context = contexto;
        }
        //Traer todos los registros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NotasModel>>> GetNotasItems()
        {
            return await _context.Tbl_Notas.ToListAsync();
        }


        //Insert
        [HttpPost]
        public async Task<ActionResult<NotasModel>> PostAlumno(NotasModel item)

        {
            _context.Tbl_Notas.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetNotasItems), new { id = item.IDNota }, item);
        }


        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotasItem(int id, NotasModel item)
        {
            if (id != item.IDNota)
            {
                return BadRequest();

            }
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("{buscar}/{resultado}")]
        public async Task<IEnumerable<NotasModel>> Estado(string resultado)
        {
            IQueryable<NotasModel> query = _context.Tbl_Notas;
            if (!string.IsNullOrEmpty(resultado))
            {
                query = query.Where(e => e.resultado.Contains(resultado));


            }
            return await query.ToListAsync();

        }




    }
}
