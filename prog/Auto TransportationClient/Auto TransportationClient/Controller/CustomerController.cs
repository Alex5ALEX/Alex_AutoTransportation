using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using static System.Runtime.InteropServices.JavaScript.JSType;

using Auto_TransportationClient.Models;
using System.Text.Json.Serialization;
using System;

namespace Auto_TransportationClient.Controller;
public class CustomerController
{
    private HttpClient httpClient;
    private readonly Uri urlCustomer;
    //private readonly Uri urlPerson;


    public CustomerController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlCustomer = new Uri("https://localhost:7180/api/Customer");
        //urlPerson = new Uri("https://localhost:7036/api/person");

    }

    public async Task<List<Customer>> GetAll()
    {
        var response = await httpClient.GetAsync(urlCustomer);

        if (!response.IsSuccessStatusCode){ return null; }

        var data = await response.Content.ReadAsStringAsync();

        var customers = JsonConvert.DeserializeObject<List<Customer>>(data);

        return customers; 
    }

    public async Task<Customer> GetById(Guid Id )
    {
        var response = await httpClient.GetAsync(urlCustomer + $"/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var customer = JsonConvert.DeserializeObject<Customer>(data);

        return customer;
    }


    
    public async Task<Customer> GetByIdPerson(Guid Id)
    {
        var response = await httpClient.GetAsync(urlCustomer + $"/id_person/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Customer>(data);

        return content;
    }



    public async Task<bool> Post(Customer customer)
    {
        var response = await httpClient.PostAsJsonAsync(urlCustomer, customer);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(Customer customer)
    {
        var response = await httpClient.PutAsJsonAsync(urlCustomer + $"/{customer.Id}", customer);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Del(Customer customer)
    {  
        var response = await  httpClient.DeleteAsync(urlCustomer + $"/{customer.Id}");

        if (!response.IsSuccessStatusCode) { return false; }

        return true;

    }

}
