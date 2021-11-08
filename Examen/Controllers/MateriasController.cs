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
    public class MateriasController : ControllerBase
    {
        private readonly Conn _context;


        public MateriasController (Conn contexto)
        {
            _context = contexto;
        }



        //Traer todos los registros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MateriasModel>>> GetMateriasItems()
        {
            return await _context.Tbl_Materias.ToListAsync();
        }



        //Insert
        [HttpPost]
        public async Task<ActionResult<MateriasModel>> PostMateria(MateriasModel item)

        {
            _context.Tbl_Materias.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMateriasItems), new { id = item.IDMateria }, item);
        }


        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateriaItem(int id, MateriasModel item)
        {
            if (id != item.IDMateria)
            {
                return BadRequest();

            }
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }





    }
}
