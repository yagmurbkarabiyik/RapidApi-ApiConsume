using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies1.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "823cd53903msh4bacd1f0a27df74p10ceecjsn24cda21d87c0" },
        { "X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovieViewModels=JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);    
                return View(apiMovieViewModels);
            }
        }
    }
}
