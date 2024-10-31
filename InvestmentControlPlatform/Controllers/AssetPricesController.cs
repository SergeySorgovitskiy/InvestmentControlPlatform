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
    public class AssetPricesController : ControllerBase
    {
        private readonly InvestmentControlPlatformDbContext _context;

        public AssetPricesController(InvestmentControlPlatformDbContext context)
        {
            _context = context;
        }

        // GET: api/AssetPrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetPrice>>> GetAssetPrices()
        {
            return await _context.AssetPrices.ToListAsync();
        }

        // GET: api/AssetPrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetPrice>> GetAssetPrice(int id)
        {
            var assetPrice = await _context.AssetPrices.FindAsync(id);

            if (assetPrice == null)
            {
                return NotFound();
            }

            return assetPrice;
        }

        // PUT: api/AssetPrices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssetPrice(int id, AssetPrice assetPrice)
        {
            if (id != assetPrice.AssetPriceId)
            {
                return BadRequest();
            }

            _context.Entry(assetPrice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetPriceExists(id))
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

        // POST: api/AssetPrices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssetPrice>> PostAssetPrice(AssetPrice assetPrice)
        {
            _context.AssetPrices.Add(assetPrice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssetPrice", new { id = assetPrice.AssetPriceId }, assetPrice);
        }

        // DELETE: api/AssetPrices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssetPrice(int id)
        {
            var assetPrice = await _context.AssetPrices.FindAsync(id);
            if (assetPrice == null)
            {
                return NotFound();
            }

            _context.AssetPrices.Remove(assetPrice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssetPriceExists(int id)
        {
            return _context.AssetPrices.Any(e => e.AssetPriceId == id);
        }
    }
}
