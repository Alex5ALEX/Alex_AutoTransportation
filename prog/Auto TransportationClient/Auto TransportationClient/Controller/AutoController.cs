using Auto_TransportationClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Auto_TransportationClient.Controller;
public class AutoController
{
    private HttpClient httpClient;
    private readonly Uri urlAuto;


    public AutoController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlAuto = new Uri("https://localhost:7180/api/Auto");

    }

    public async Task<List<Auto>> GetAll()
    {
        var response = await httpClient.GetAsync(urlAuto);

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var auto = JsonConvert.DeserializeObject<List<Auto>>(data);

        return auto;
    }

    public async Task<Auto> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(urlAuto + $"/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var auto = JsonConvert.DeserializeObject<Auto>(data);

        return auto;
    }

    public async Task<bool> Post(Auto auto)
    {
        var response = await httpClient.PostAsJsonAsync(urlAuto, auto);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(Auto auto)
    {
        var response = await httpClient.PutAsJsonAsync(urlAuto + $"/{auto.Id}", auto);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Del(Auto auto)
    {
        var response = await httpClient.DeleteAsync(urlAuto + $"/{auto.Id}");

        if (!response.IsSuccessStatusCode) { return false; }

        return true;

    }




}
