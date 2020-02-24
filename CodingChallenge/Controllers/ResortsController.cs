using System.Linq;
using CodingChallenge.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResortsController : ControllerBase
    {
        private readonly DatabaseContext database;

        public ResortsController(DatabaseContext database)
        {
            this.database = database ?? throw new System.ArgumentNullException(nameof(database));
        }

        [HttpGet]
        public IActionResult Get(string country)
        {
            var resorts = database.Set<Resort>()
                                  .AsQueryable();

            if (!string.IsNullOrWhiteSpace(country))
            {
                resorts = resorts.Where(r => r.Country == country);
            }

            return new OkObjectResult(resorts);
        }
    }
}