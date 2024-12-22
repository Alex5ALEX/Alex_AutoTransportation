using AutoTransportationServer.Data;
using AutoTransportationServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoTransportationServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly TransportationDbContext _context;

    public AdminController(TransportationDbContext context)
    {
        _context = context;
    }

    // GET: api/<FuelController>
    [HttpGet]
    public Task<List<Admin>> Get()
    {
        return _context.Admins.Include(a => a.Person).ToListAsync();
    }

    // GET api/<FuelController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var model = await _context.Admins.Where(f => f.Id == id).Include(a => a.Person).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }

    // POST api/<FuelController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Admin admin)
    {
        admin.Id = new Guid();
        admin.Person.Id = new Guid();

        var person = _context.Persons.FirstOrDefault(f => f.Login == admin.Person.Login);

        if (person != null) { return BadRequest("login exist"); }

        await _context.Persons.AddAsync(admin.Person);

        await _context.Admins.AddAsync(admin);
        _context.SaveChanges();

        return Ok(admin);
    }

    // PUT api/<FuelController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Admin value)
    {
        value.Id = id;
        _context.Admins.Update(value);
        _context.SaveChanges();
        return Ok(value);
    }

    // DELETE api/<FuelController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var admin = await _context.Admins.Where(f => f.Id == id).SingleOrDefaultAsync();

        if (admin == null){ return NotFound(); }
       
        var person = await _context.Persons.FindAsync(admin.PersonId);


        _context.Persons.Remove(person);
        //_context.Admins.Remove(model);
        _context.SaveChanges();
        return Ok(admin);
    }
}
