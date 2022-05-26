using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodingChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var httpClient = new HttpClient { BaseAddress = new Uri("https://skizoominterviewchallenge.azurewebsites.net") };

            var response = await httpClient.GetAsync("/api/hotels?code=7hnVjCOrnMYAA49pAy/sBnxf4OZZpv8j8fwQ4B8tSNyowaN4cfaKYQ==");

            var content = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(content);
        }

        [HttpGet]
        [Route("italian")]
        public async Task<IActionResult> GetNewProviderHotels()
        {
            // TASK
            // 1 - how do we combine this data neatly into the main endpoint above, so that all hotels are available under /api/hotels?
            // 2 - how can we make this controller more SOLID?
            // 3 - the APIs we connect to can be randomly quite slow, what can we do so this doesn't affect our app?
            // 4 - if we connect to more hotel providers in future, how could we do this neatly?

            var httpClient = new HttpClient { BaseAddress = new Uri("https://skizoominterviewchallenge.azurewebsites.net") };

            var response = await httpClient.GetAsync("/api/residenza?code=En1OvN8w29jYh0BYv5ogeN2JVZt_zB8PZqTtpRK_PvB9AzFuTk3FYQ==");

            var content = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(content);
        }
    }
}