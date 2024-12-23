using Auto_TransportationClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Auto_TransportationClient.Controller;
public class TransportationController
{

    private HttpClient httpClient;
    private readonly Uri urlTransportation;



    public TransportationController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlTransportation = new Uri("https://localhost:7180/api/Transportation");
 

    }

    public async Task<List<Transportation>> GetAll()
    {
        var response = await httpClient.GetAsync(urlTransportation);

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var transportations = JsonConvert.DeserializeObject<List<Transportation>>(data);
        
        return transportations;
    }

    public async Task<Transportation> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(urlTransportation + $"/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var transportation = JsonConvert.DeserializeObject<Transportation>(data);

        return transportation;
    }

    public async Task<List<Transportation>> GetByIdCustomer(Guid Id)
    {
        var response = await httpClient.GetAsync(urlTransportation + $"/id_customer/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var transportation = JsonConvert.DeserializeObject<List<Transportation>>(data);

        return transportation;
    }


    public async Task<bool> Post(Transportation transportation)
    {
        var response = await httpClient.PostAsJsonAsync(urlTransportation, transportation);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(Transportation transportation)
    {
        var response = await httpClient.PutAsJsonAsync(urlTransportation + $"/{transportation.Id}", transportation);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Del(Transportation transportation)
    {
        var response = await httpClient.DeleteAsync(urlTransportation + $"/{transportation.Id}");

        if (!response.IsSuccessStatusCode) { return false; }

        return true;

    }

}
