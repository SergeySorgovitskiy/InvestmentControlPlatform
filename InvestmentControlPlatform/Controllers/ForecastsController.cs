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
    public class ForecastsController : ControllerBase
    {
        private readonly InvestmentControlPlatformDbContext _context;

        public ForecastsController(InvestmentControlPlatformDbContext context)
        {
            _context = context;
        }

        // GET: api/Forecasts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Forecast>>> GetForecasts()
        {
            return await _context.Forecasts.ToListAsync();
        }

        // GET: api/Forecasts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Forecast>> GetForecast(int id)
        {
            var forecast = await _context.Forecasts.FindAsync(id);

            if (forecast == null)
            {
                return NotFound();
            }

            return forecast;
        }

        // PUT: api/Forecasts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForecast(int id, Forecast forecast)
        {
            if (id != forecast.ForecastId)
            {
                return BadRequest();
            }

            _context.Entry(forecast).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForecastExists(id))
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

        // POST: api/Forecasts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Forecast>> PostForecast(Forecast forecast)
        {
            _context.Forecasts.Add(forecast);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForecast", new { id = forecast.ForecastId }, forecast);
        }

        // DELETE: api/Forecasts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForecast(int id)
        {
            var forecast = await _context.Forecasts.FindAsync(id);
            if (forecast == null)
            {
                return NotFound();
            }

            _context.Forecasts.Remove(forecast);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForecastExists(int id)
        {
            return _context.Forecasts.Any(e => e.ForecastId == id);
        }
    }
}
