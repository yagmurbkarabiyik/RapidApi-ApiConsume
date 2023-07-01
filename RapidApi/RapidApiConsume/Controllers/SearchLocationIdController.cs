using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Reflection;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIdController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if(!string.IsNullOrEmpty(cityName))
            {
                List<BookingApiSearchLocationViewModel> bookingApiSearchLocationViewModels = new List<BookingApiSearchLocationViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "823cd53903msh4bacd1f0a27df74p10ceecjsn24cda21d87c0" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<List<BookingApiSearchLocationViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
            else
            {
                List<BookingApiSearchLocationViewModel> bookingApiSearchLocationViewModels = new List<BookingApiSearchLocationViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Berlin&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "823cd53903msh4bacd1f0a27df74p10ceecjsn24cda21d87c0" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<List<BookingApiSearchLocationViewModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
        }
        }
            
        }
