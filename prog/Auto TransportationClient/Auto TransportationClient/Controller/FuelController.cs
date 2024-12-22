using Auto_TransportationClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Auto_TransportationClient.Controller;
public class FuelController
{
    private HttpClient httpClient;
    private readonly Uri urlFuel;


    public FuelController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlFuel = new Uri("https://localhost:7180/api/Fuel");

    }

    public async Task<List<Fuel>> GetAll()
    {
        var response = await httpClient.GetAsync(urlFuel);

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var fuels = JsonConvert.DeserializeObject<List<Fuel>>(data);

        return fuels;
    }

    public async Task<Fuel> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(urlFuel + $"/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var fuel = JsonConvert.DeserializeObject<Fuel>(data);

        return fuel;
    }


    public async Task<bool> Post(Fuel fuel)
    {
        var response = await httpClient.PostAsJsonAsync(urlFuel, fuel);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(Fuel fuel)
    {
        var response = await httpClient.PutAsJsonAsync(urlFuel + $"/{fuel.Id}", fuel);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Del(Fuel fuel)
    {
        var response = await httpClient.DeleteAsync(urlFuel + $"/{fuel.Id}");

        if (!response.IsSuccessStatusCode) { return false; }

        return true;

    }


}
