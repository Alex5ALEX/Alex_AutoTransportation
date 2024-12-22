using AutoTransportationServer.Data;
using AutoTransportationServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoTransportationServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FuelController : ControllerBase
{
    private readonly TransportationDbContext _context;

    public FuelController(TransportationDbContext context)
    {
        _context = context;
    }

    // GET: api/<FuelController>
    [HttpGet]
    public Task<List<Fuel>> Get()
    {
        return _context.Fuel.ToListAsync();
    }

    // GET api/<FuelController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var model = await _context.Fuel.Where(f => f.Id == id).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }

    // POST api/<FuelController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Fuel customer)
    {
        customer.Id = new Guid();

        await _context.Fuel.AddAsync(customer);
        _context.SaveChanges();

        return Ok(customer);
    }

    // PUT api/<FuelController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Fuel value)
    {
        value.Id = id;
        _context.Fuel.Update(value);
        _context.SaveChanges();
        return Ok(value);
    }

    // DELETE api/<FuelController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var model = await _context.Fuel.Where(f => f.Id == id).SingleOrDefaultAsync();
        if(model == null)
        {
            return NotFound();
        }
        _context.Fuel.Remove(model);
        _context.SaveChanges();
        return Ok(model);
    }
}
