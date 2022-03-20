using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatementDetail1Controller : ControllerBase
    {
        private readonly StatementDetailContext _context;

        public StatementDetail1Controller(StatementDetailContext context)
        {
            _context = context;
        }

        // GET: api/StatementDetail1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatementDetail1>>> GetStatementDetails1()
        {
            return await _context.StatementDetails1.ToListAsync();
        }

        // GET: api/StatementDetail1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatementDetail1>> GetStatementDetail1(int id)
        {
            var statementDetail1 = await _context.StatementDetails1.FindAsync(id);

            if (statementDetail1 == null)
            {
                return NotFound();
            }

            return statementDetail1;
        }

        // PUT: api/StatementDetail1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatementDetail1(int id, StatementDetail1 statementDetail1)
        {
            if (id != statementDetail1.StatementDetailId1)
            {
                return BadRequest();
            }

            _context.Entry(statementDetail1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatementDetail1Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StatementDetail1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StatementDetail1>> PostStatementDetail1(StatementDetail1 statementDetail1)
        {
            _context.StatementDetails1.Add(statementDetail1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatementDetail1", new { id = statementDetail1.StatementDetailId1 }, statementDetail1);
        }

        // DELETE: api/StatementDetail1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatementDetail1(int id)
        {
            var statementDetail1 = await _context.StatementDetails1.FindAsync(id);
            if (statementDetail1 == null)
            {
                return NotFound();
            }

            _context.StatementDetails1.Remove(statementDetail1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatementDetail1Exists(int id)
        {
            return _context.StatementDetails1.Any(e => e.StatementDetailId1 == id);
        }
    }
}
