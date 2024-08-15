using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ConsumoApi
    { 
        //public  async Task GetResponse()
        //{
        //    // Crear un cliente HTTP
        //    var client = new HttpClient();

        //    System.Console.WriteLine("Proporciona un anime:");
        //    string objetivo = Console.ReadLine();
        //    System.Console.WriteLine(objetivo);
        //    // Realizar la solicitud GET a la API de Jikan
        //    var response = await client.GetAsync($"https://api.jikan.moe/v4/anime?q={objetivo}&sfw");

        //    // Verificar si la respuesta fue exitosa
        //    if (response.IsSuccessStatusCode)
        //    {
        //        // Leer la respuesta como un string
        //        var responseBody = await response.Content.ReadAsStringAsync();

        //        // Deserializar la respuesta JSON en un objeto .NET
        //        var topAnimeResponse = JsonSerializer.Deserialize<TopAnimeResponse>(responseBody);

        //        // Mostrar los resultados
        //        foreach (var anime in topAnimeResponse.Top)
        //        {
        //            Console.WriteLine($"Rank: {anime.Rank} - {anime.Title} ({anime.Score})");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error al consultar la API: " + response.StatusCode);
        //    }
        //}
    }
}