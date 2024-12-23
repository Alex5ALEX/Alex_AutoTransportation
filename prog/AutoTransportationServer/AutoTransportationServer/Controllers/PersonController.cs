using AutoTransportationServer.Data;
using AutoTransportationServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoTransportationServer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly TransportationDbContext _context;

    public PersonController(TransportationDbContext context)
    {
        _context = context;
    }

    // GET: api/<FuelController>
    [HttpGet]
    public Task<List<Person>> Get()
    {
        return _context.Persons.ToListAsync();
    }

    // GET api/<FuelController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var model = await _context.Persons.Where(f => f.Id == id).SingleOrDefaultAsync();
        return model != null ? Ok(model) : NotFound();
    }

    [HttpGet("login/{login}/{password}")]
    public async Task<IActionResult> Login(string login, string password)
    {
        var person = await _context.Persons.FirstOrDefaultAsync(p => p.Login == login && p.Password == password);

        if (person == null)
        {
            return BadRequest("Not found");
        }

        var customer = await _context.Customers.FirstOrDefaultAsync(p => p.PersonId == person.Id);
        var admin = await _context.Admins.FirstOrDefaultAsync(p => p.PersonId == person.Id);

        if (customer != null)
        {
            return Ok("Customer");
        }
        else if (admin != null)
        {
            return Ok("Admin");
        }

        return BadRequest("Not found");
    }



    [HttpGet("input_login/{login}/pass/{password}")]
    public async Task<IActionResult> InputLogin(string login, string password)
    {
        var person = await _context.Persons.FirstOrDefaultAsync(p => p.Login == login && p.Password == password);

        if (person == null)
        {
            return BadRequest("Not found");
        }

        return Ok(person);
    }

    // POST api/<FuelController>
    /*
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Person customer)
    {
        customer.Id = new Guid();

        await _context.Persons.AddAsync(customer);
        _context.SaveChanges();

        return Ok(customer);
    }*/

    // PUT api/<FuelController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Person value)
    {
        value.Id = id;

        var person = _context.Persons.FirstOrDefault(a => a.Login == value.Login);

        if (person != null && person.Id != value.Id) { return BadRequest("login exist"); }

        var edit = _context.Persons.Find(id);

        edit.Name = value.Name;
        edit.Surname = value.Surname;
        edit.Phone = value.Phone;
        edit.Email = value.Email;
        edit.Address = value.Address;
        edit.Login = value.Login;
        edit.Password = value.Password;


        _context.Persons.Update(edit);
        _context.SaveChanges();
        return Ok(value);
    }

    // DELETE api/<FuelController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var model = await _context.Persons.Where(f => f.Id == id).SingleOrDefaultAsync();
        if (model == null)
        {
            return NotFound();
        }
        _context.Persons.Remove(model);
        _context.SaveChanges();
        return Ok(model);
    }
}
