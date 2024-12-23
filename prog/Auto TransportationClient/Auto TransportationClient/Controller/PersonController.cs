using Auto_TransportationClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_TransportationClient.Controller;
public class PersonController
{
    private HttpClient httpClient;
    private readonly Uri urlPerson;


    public PersonController(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        urlPerson = new Uri("https://localhost:7180/api/Person");
    }


    public async Task<string> LoginAsync(string login, string password)
    {
        try
        {
            // Формируем URL для запроса
            string url = $"{urlPerson}/login/{login}/{password}";

            // Выполняем GET-запрос
            var response = await httpClient.GetAsync(url);

            // Проверяем статус ответа
            if (response.IsSuccessStatusCode)
            {
                // Читаем содержимое ответа
                string result = await response.Content.ReadAsStringAsync();
                return result; // Возвращаем результат (Customer или Admin)
            }
            else
            {
                return "Login failed: " + response.ReasonPhrase;
            }
        }
        catch (Exception ex)
        {
            return "An error occurred: " + ex.Message;
        }
    }

    public async Task<Person> GetByLogin(string login, string password)
    {
        var response = await httpClient.GetAsync($"{urlPerson}/input_login/{login}/pass/{password}");



        if (!response.IsSuccessStatusCode)
        {
            return new Person();
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Person>(data);

        return content;


    }



}
