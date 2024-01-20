using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;

Stopwatch stopwatch = new();
Stopwatch stopwatchTwo = new();
HttpClient client = new();
WebClient webClient = new();

stopwatch.Start();
await GetFilmAsync();
stopwatch.Stop();

await Task.Delay(200);
Console.WriteLine();
Console.WriteLine();

stopwatchTwo.Start();
new Thread(GetFilms).Start();
stopwatchTwo.Stop();


void GetFilms()
{
    var response = webClient.DownloadString("https://swapi.dev/api/films/");
    var result = JsonConvert.DeserializeObject<FilmResponse>(response);

    foreach (var item in result!.results)
    {
        Console.WriteLine($"Title: Star Wars {item.title} " +
                          $"\nDirector: {item.director} " +
                          $"\nProducer: {item.producer} " +
                          $"\nRelease date: {item.release_date}");
    }
}

Console.WriteLine($"Время выполнения not async метода: {stopwatchTwo.ElapsedMilliseconds} миллисекунд");

async Task GetFilmAsync()
{
    var response = await client.GetStringAsync("https://swapi.dev/api/films/");
    var result = JsonConvert.DeserializeObject<FilmResponse>(response);

    foreach (var item in result!.results)
    {
        Console.WriteLine($"Title: Star Wars {item.title} " +
                          $"\nDirector: {item.director} " +
                          $"\nProducer: {item.producer} " +
                          $"\nRelease date: {item.release_date}");
    }
}

Console.WriteLine($"Время выполнения async метода: {stopwatch.ElapsedMilliseconds} миллисекунд");

public class Movie
{
    public string title { get; set; }
    public string release_date { get; set; }
    public string director { get; set; }
    public string producer { get; set; }
}

public class FilmResponse
{
    public List<Movie> results { get; set; }
}