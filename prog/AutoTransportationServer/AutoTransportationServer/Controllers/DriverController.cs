using AutoTransportationServer.Data;
using AutoTransportationServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoTransportationServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DriverController : ControllerBase
{
    private readonly TransportationDbContext _context;

    public DriverController(TransportationDbContext context)
    {
        _context = context;
    }

    // GET: api/<AutoController>
    [HttpGet]
    public Task<List<Driver>> Get()
    {
        return _context.Drivers.Include(a => a.Auto).ToListAsync();
    }

    // GET api/<FuelController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var model = await _context.Drivers.Where(f => f.Id == id).Include(a => a.Auto).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }

    // POST api/<FuelController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Driver value)
    {
        value.Id = new Guid();

        await _context.Drivers.AddAsync(value);
        _context.SaveChanges();

        return Ok(value);
    }

    // PUT api/<FuelController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Driver value)
    {
        value.Id = id;
        _context.Drivers.Update(value);
        _context.SaveChanges();
        return Ok(value);
    }

    // DELETE api/<FuelController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var model = await _context.Drivers.Where(f => f.Id == id).SingleOrDefaultAsync();
        if (model == null)
        {
            return NotFound();
        }
        _context.Drivers.Remove(model);
        _context.SaveChanges();
        return Ok(model);
    }
}
