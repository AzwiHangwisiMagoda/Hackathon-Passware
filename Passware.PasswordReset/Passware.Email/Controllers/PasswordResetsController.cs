using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Passware.Email.Data;
using Passware.Email.Models;

namespace Passware.Email.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordResetsController : ControllerBase
    {
        private readonly PasswareEmailContext _context;

        public PasswordResetsController(PasswareEmailContext context)
        {
            _context = context;
        }

        // GET: api/PasswordResets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passware.Email.Models.PasswordReset>>> GetPasswordReset()
        {
            return await _context.PasswordReset.ToListAsync();
        }

        // GET: api/PasswordResets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Passware.Email.Models.PasswordReset>> GetPasswordReset(Guid id)
        {
            var passwordReset = await _context.PasswordReset.FindAsync(id);

            if (passwordReset == null)
            {
                return NotFound();
            }

            return passwordReset;
        }

        // PUT: api/PasswordResets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPasswordReset(Guid id, Passware.Email.Models.PasswordReset passwordReset)
        {
            if (id != passwordReset.Id)
            {
                return BadRequest();
            }

            _context.Entry(passwordReset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PasswordResetExists(id))
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

        // POST: api/PasswordResets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Passware.Email.Models.PasswordReset>> PostPasswordReset(Passware.Email.Models.PasswordReset passwordReset)
        {
            _context.PasswordReset.Add(passwordReset);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPasswordReset", new { id = passwordReset.Id }, passwordReset);
        }

        // DELETE: api/PasswordResets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Passware.Email.Models.PasswordReset>> DeletePasswordReset(Guid id)
        {
            var passwordReset = await _context.PasswordReset.FindAsync(id);
            if (passwordReset == null)
            {
                return NotFound();
            }

            _context.PasswordReset.Remove(passwordReset);
            await _context.SaveChangesAsync();

            return passwordReset;
        }

        private bool PasswordResetExists(Guid id)
        {
            return _context.PasswordReset.Any(e => e.Id == id);
        }
    }
}
