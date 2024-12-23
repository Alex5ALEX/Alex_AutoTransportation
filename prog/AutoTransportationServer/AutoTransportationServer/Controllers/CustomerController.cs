using AutoTransportationServer.Data;
using AutoTransportationServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoTransportationServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly TransportationDbContext _context;

    public CustomerController(TransportationDbContext context)
    {
        _context = context;
    }

    // GET: api/<FuelController>
    [HttpGet]
    public Task<List<Customer>> Get()
    {
        return _context.Customers.Include(a => a.Person).Include(a => a.Transportations).ToListAsync();
    }

    // GET api/<FuelController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var model = await _context.Customers.Where(f => f.Id == id).Include(a => a.Person).Include(c => c.Transportations).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }


    [HttpGet("id_person/{id}")]
    public async Task<IActionResult> GetByIdPerson(Guid id)
    {
        var model = await _context.Customers.Where(f => f.PersonId == id).Include(a => a.Person).Include(c => c.Transportations).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }


    // POST api/<FuelController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Customer customer)
    {
        customer.Id = new Guid();
        customer.Person.Id = new Guid();

        var person = _context.Persons.FirstOrDefault(f => f.Login == customer.Person.Login);

        if(person != null) { return BadRequest("login exist"); }

        await _context.Persons.AddAsync(customer.Person);
        
        await _context.Customers.AddAsync(customer);
        _context.SaveChanges();

        return Ok(customer);
    }

    // PUT api/<FuelController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Customer value)
    {
        value.Id = id;

        var person = _context.Persons.FirstOrDefault(f => f.Login == value.Person.Login);

        if (person != null) { return BadRequest("login exist"); }

        _context.Persons.Update(value.Person);
        _context.Customers.Update(value);
        _context.SaveChanges();
        return Ok(value);
    }

    // DELETE api/<FuelController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var customer = await _context.Customers.Where(f => f.Id == id).SingleOrDefaultAsync();

        if (customer == null)
        {
            return NotFound();
        }

        var person = await _context.Persons.FindAsync(customer.PersonId);


        _context.Persons.Remove(person);
        //_context.Customers.Remove(customer);
        _context.SaveChanges();
        return Ok(customer);
    }
}
