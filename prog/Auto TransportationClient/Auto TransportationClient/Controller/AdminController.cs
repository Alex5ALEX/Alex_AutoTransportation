using Auto_TransportationClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Auto_TransportationClient.Controller;
public class AdminController 
{
    private HttpClient httpClient;
    private readonly Uri urlAdmin;
    //private readonly Uri urlPerson;


    public AdminController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlAdmin = new Uri("https://localhost:7180/api/Admin");
        //urlPerson = new Uri("https://localhost:7036/api/person");

    }

    public async Task<List<Admin>> GetAll()
    {
        var response = await httpClient.GetAsync(urlAdmin);

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var admins = JsonConvert.DeserializeObject<List<Admin>>(data);

        return admins;
    }

    public async Task<Admin> GetById(Guid Id)
    {
        var response = await httpClient.GetAsync(urlAdmin + $"/{Id}");

        if (!response.IsSuccessStatusCode) { return null; }

        var data = await response.Content.ReadAsStringAsync();

        var admin = JsonConvert.DeserializeObject<Admin>(data);

        return admin;
    }


    /*
    public async Task<Customer> GetByIdPerson(Guid Id)
    {
        var response = await httpClient.GetAsync(urlCustomer + $"/id_person/{Id}");
        //var response = await httpClient.GetAsync(url + $"/{Id.ToString()}");


        if (!response.IsSuccessStatusCode)
        {
            return new Customer();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Customer>(data);

        return content;


    }*/



    public async Task<bool> Post(Admin admin)
    {
        var response = await httpClient.PostAsJsonAsync(urlAdmin, admin);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Put(Admin admin)
    {
        var response = await httpClient.PutAsJsonAsync(urlAdmin + $"/{admin.Id}", admin);

        if (!response.IsSuccessStatusCode) { return false; }

        return true;
    }


    public async Task<bool> Del(Admin admin)
    {
        var response = await httpClient.DeleteAsync(urlAdmin + $"/{admin.Id}");

        if (!response.IsSuccessStatusCode) { return false; }

        return true;

    }




}
