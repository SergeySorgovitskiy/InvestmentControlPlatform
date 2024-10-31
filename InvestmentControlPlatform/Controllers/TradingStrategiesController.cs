using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InvestmentControlPlatform.DataAccess.Models;

namespace InvestmentControlPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradingStrategiesController : ControllerBase
    {
        private readonly InvestmentControlPlatformDbContext _context;

        public TradingStrategiesController(InvestmentControlPlatformDbContext context)
        {
            _context = context;
        }

        // GET: api/TradingStrategies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TradingStrategy>>> GetTradingStrategies()
        {
            return await _context.TradingStrategies.ToListAsync();
        }

        // GET: api/TradingStrategies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TradingStrategy>> GetTradingStrategy(int id)
        {
            var tradingStrategy = await _context.TradingStrategies.FindAsync(id);

            if (tradingStrategy == null)
            {
                return NotFound();
            }

            return tradingStrategy;
        }

        // PUT: api/TradingStrategies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTradingStrategy(int id, TradingStrategy tradingStrategy)
        {
            if (id != tradingStrategy.StrategyId)
            {
                return BadRequest();
            }

            _context.Entry(tradingStrategy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TradingStrategyExists(id))
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

        // POST: api/TradingStrategies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TradingStrategy>> PostTradingStrategy(TradingStrategy tradingStrategy)
        {
            _context.TradingStrategies.Add(tradingStrategy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTradingStrategy", new { id = tradingStrategy.StrategyId }, tradingStrategy);
        }

        // DELETE: api/TradingStrategies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTradingStrategy(int id)
        {
            var tradingStrategy = await _context.TradingStrategies.FindAsync(id);
            if (tradingStrategy == null)
            {
                return NotFound();
            }

            _context.TradingStrategies.Remove(tradingStrategy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TradingStrategyExists(int id)
        {
            return _context.TradingStrategies.Any(e => e.StrategyId == id);
        }
    }
}
