using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoneyBadgers._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HoneyBadgers._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendshipsController : ControllerBase
    {
        private readonly HoneyBadgerDBContext _context;

        public FriendshipsController(HoneyBadgerDBContext context)
        {
            _context = context;
        }

        // GET: api/Friendships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Friendship>>> GetFriendship()
        {
            return await _context.Friendship.ToListAsync();
        }

        // GET: api/Friendships/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Friendship>> GetFriendship(int id)
        {
            var friendship = await _context.Friendship.FindAsync(id);

            if (friendship == null)
            {
                return NotFound();
            }

            return friendship;
        }

        // PUT: api/Friendships/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFriendship(int id, Friendship friendship)
        {
            if (id != friendship.FriendshipId)
            {
                return BadRequest();
            }

            _context.Entry(friendship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FriendshipExists(id))
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

        // POST: api/Friendships
        [HttpPost]
        public async Task<ActionResult<Friendship>> PostFriendship(Friendship friendship)
        {
            _context.Friendship.Add(friendship);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FriendshipExists(friendship.FriendshipId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFriendship", new { id = friendship.FriendshipId }, friendship);
        }

        // DELETE: api/Friendships/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Friendship>> DeleteFriendship(int id)
        {
            var friendship = await _context.Friendship.FindAsync(id);
            if (friendship == null)
            {
                return NotFound();
            }

            _context.Friendship.Remove(friendship);
            await _context.SaveChangesAsync();

            return friendship;
        }

        private bool FriendshipExists(int id)
        {
            return _context.Friendship.Any(e => e.FriendshipId == id);
        }
    }
}
