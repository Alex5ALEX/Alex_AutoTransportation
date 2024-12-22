using AutoTransportationServer.Data;
using AutoTransportationServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoTransportationServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AutoController : ControllerBase
{
    private readonly TransportationDbContext _context;

    public AutoController(TransportationDbContext context)
    {
        _context = context;
    }

    // GET: api/<AutoController>
    [HttpGet]
    public Task<List<Auto>> Get()
    {
        return _context.Autos.Include(a => a.Drivers).Include(a => a.Fuel).ToListAsync();
    }

    // GET api/<FuelController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var model = await _context.Autos.Where(f => f.Id == id).Include(a => a.Drivers).Include(a => a.Fuel).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }

    // POST api/<FuelController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Auto value)
    {
        value.Id = new Guid();

        await _context.Autos.AddAsync(value);
        _context.SaveChanges();

        return Ok(value);
    }

    // PUT api/<FuelController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Auto value)
    {
        value.Id = id;
        _context.Autos.Update(value);
        _context.SaveChanges();
        return Ok(value);
    }

    // DELETE api/<FuelController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var model = await _context.Autos.Where(f => f.Id == id).SingleOrDefaultAsync();
        if (model == null)
        {
            return NotFound();
        }
        _context.Autos.Remove(model);
        _context.SaveChanges();
        return Ok(model);
    }
}
