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
    public class PortfolioAssetsController : ControllerBase
    {
        private readonly InvestmentControlPlatformDbContext _context;

        public PortfolioAssetsController(InvestmentControlPlatformDbContext context)
        {
            _context = context;
        }

        // GET: api/PortfolioAssets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PortfolioAsset>>> GetPortfolioAssets()
        {
            return await _context.PortfolioAssets.ToListAsync();
        }

        // GET: api/PortfolioAssets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PortfolioAsset>> GetPortfolioAsset(int id)
        {
            var portfolioAsset = await _context.PortfolioAssets.FindAsync(id);

            if (portfolioAsset == null)
            {
                return NotFound();
            }

            return portfolioAsset;
        }

        // PUT: api/PortfolioAssets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPortfolioAsset(int id, PortfolioAsset portfolioAsset)
        {
            if (id != portfolioAsset.PortfolioAssetId)
            {
                return BadRequest();
            }

            _context.Entry(portfolioAsset).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PortfolioAssetExists(id))
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

        // POST: api/PortfolioAssets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PortfolioAsset>> PostPortfolioAsset(PortfolioAsset portfolioAsset)
        {
            _context.PortfolioAssets.Add(portfolioAsset);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPortfolioAsset", new { id = portfolioAsset.PortfolioAssetId }, portfolioAsset);
        }

        // DELETE: api/PortfolioAssets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePortfolioAsset(int id)
        {
            var portfolioAsset = await _context.PortfolioAssets.FindAsync(id);
            if (portfolioAsset == null)
            {
                return NotFound();
            }

            _context.PortfolioAssets.Remove(portfolioAsset);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PortfolioAssetExists(int id)
        {
            return _context.PortfolioAssets.Any(e => e.PortfolioAssetId == id);
        }
    }
}
