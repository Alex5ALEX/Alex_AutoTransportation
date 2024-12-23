using Auto_TransportationClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Auto_TransportationClient.Controller;
public class DriverController
{

   
    private HttpClient httpClient;
    private readonly Uri urlDriver;
    //private readonly Uri urlPerson;


    public DriverController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlDriver = new Uri("https://localhost:7180/api/Driver");
        //urlPerson = new Uri("https://localhost:7036/api/person");

    }

    public async Task<List<Driver>> GetAll()
    {
        var response = await httpClient.GetAsync(urlDriver);

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var driver = JsonConvert.DeserializeObject<List<Driver>>(data);

        return driver;
    }

    public async Task<Driver> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(urlDriver + $"/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var driver = JsonConvert.DeserializeObject<Driver>(data);

        return driver;
    }


    public async Task<bool> Post(Driver driver)
    {
        var response = await httpClient.PostAsJsonAsync(urlDriver, driver);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(Driver driver)
    {
        var response = await httpClient.PutAsJsonAsync(urlDriver + $"/{driver.Id}", driver);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Del(Driver driver)
    {
        var response = await httpClient.DeleteAsync(urlDriver + $"/{driver.Id}");

        if (!response.IsSuccessStatusCode) { return false; }

        return true;

    }

}
