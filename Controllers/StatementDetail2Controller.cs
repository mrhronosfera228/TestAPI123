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
    public class StatementDetail2Controller : ControllerBase
    {
        private readonly StatementDetailContext _context;

        public StatementDetail2Controller(StatementDetailContext context)
        {
            _context = context;
        }

        // GET: api/StatementDetail2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatementDetail2>>> GetStatementDetails2()
        {
            return await _context.StatementDetails2.ToListAsync();
        }

        // GET: api/StatementDetail2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatementDetail2>> GetStatementDetail2(int id)
        {
            var statementDetail2 = await _context.StatementDetails2.FindAsync(id);

            if (statementDetail2 == null)
            {
                return NotFound();
            }

            return statementDetail2;
        }

        // PUT: api/StatementDetail2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatementDetail2(int id, StatementDetail2 statementDetail2)
        {
            if (id != statementDetail2.StatementDetailId2)
            {
                return BadRequest();
            }

            _context.Entry(statementDetail2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatementDetail2Exists(id))
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

        // POST: api/StatementDetail2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StatementDetail2>> PostStatementDetail2(StatementDetail2 statementDetail2)
        {
            _context.StatementDetails2.Add(statementDetail2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatementDetail2", new { id = statementDetail2.StatementDetailId2 }, statementDetail2);
        }

        // DELETE: api/StatementDetail2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatementDetail2(int id)
        {
            var statementDetail2 = await _context.StatementDetails2.FindAsync(id);
            if (statementDetail2 == null)
            {
                return NotFound();
            }

            _context.StatementDetails2.Remove(statementDetail2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatementDetail2Exists(int id)
        {
            return _context.StatementDetails2.Any(e => e.StatementDetailId2 == id);
        }
    }
}
