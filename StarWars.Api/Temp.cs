// using Newtonsoft.Json;
//
// HttpClient client = new HttpClient();
// await GetFilmsAsync();
//
// async Task GetFilmsAsync()
// {
//     var response = await client.GetStringAsync("https://swapi.dev/api/films/");
//     var result = JsonConvert.DeserializeObject<FilmsResponse>(response);
//
//     foreach (var item in result.results)
//     {
//         Console.WriteLine($"Title: Star Wars {item.title} " +
//                           $"\nDirector: {item.director} " +
//                           $"\nProducer: {item.producer} " +
//                           $"\nRelease date: {item.release_date}");
//     }
// }
//
// public class Movie
// {
//     public string title { get; set; }
//     public string release_date { get; set; }
//     public string director { get; set; }
//     public string producer { get; set; }
// }
//
// public class FilmsResponse
// {
//     public List<Movie> results { get; set; }
// }