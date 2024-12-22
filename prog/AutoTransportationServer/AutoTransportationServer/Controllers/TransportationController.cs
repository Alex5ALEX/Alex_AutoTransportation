using AutoTransportationServer.Data;
using AutoTransportationServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoTransportationServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TransportationController : ControllerBase
{
    private readonly TransportationDbContext _context;

    public TransportationController(TransportationDbContext context)
    {
        _context = context;
    }

    // GET: api/<AutoController>
    [HttpGet]
    public Task<List<Transportation>> Get()
    {
        return _context.Transportations.Include(a => a.Customer).Include(t => t.Driver).Include(t => t.Fuel).ToListAsync();
    }

    // GET api/<FuelController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var model = await _context.Transportations.Where(f => f.Id == id).Include(a => a.Customer).Include(t => t.Driver).Include(t => t.Fuel).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }

    // POST api/<FuelController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Transportation customer)
    {
        customer.Id = new Guid();

        await _context.Transportations.AddAsync(customer);
        _context.SaveChanges();

        return Ok(customer);
    }

    // PUT api/<FuelController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Transportation value)
    {
        value.Id = id;
        _context.Transportations.Update(value);
        _context.SaveChanges();
        return Ok(value);
    }

    // DELETE api/<FuelController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var model = await _context.Transportations.Where(f => f.Id == id).SingleOrDefaultAsync();
        if (model == null)
        {
            return NotFound();
        }
        _context.Transportations.Remove(model);
        _context.SaveChanges();
        return Ok(model);
    }
}
