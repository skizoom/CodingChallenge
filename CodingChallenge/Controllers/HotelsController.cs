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
    }
}