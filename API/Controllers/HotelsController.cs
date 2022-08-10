using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var HTTP = new HttpClient();

            var http_response = await HTTP.GetAsync("https://skizoominterviewchallenge.azurewebsites.net/api/hotels?code=7hnVjCOrnMYAA49pAy/sBnxf4OZZpv8j8fwQ4B8tSNyowaN4cfaKYQ==");

            var content = await http_response.Content.ReadAsStringAsync();

            return new OkObjectResult(content);
        }

        [HttpGet]
        [Route("italian")]
        public async Task<IActionResult> GetNewProviderHotels()
        {
            var HTTP = new HttpClient();

            var data_response = await HTTP.GetAsync("https://skizoominterviewchallenge.azurewebsites.net/api/residenza?code=En1OvN8w29jYh0BYv5ogeN2JVZt_zB8PZqTtpRK_PvB9AzFuTk3FYQ==");

            var content = await data_response.Content.ReadAsStringAsync();

            return new OkObjectResult(content);
        }
    }
}