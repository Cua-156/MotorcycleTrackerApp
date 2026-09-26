using Microsoft.AspNetCore.Mvc;
using MotorcycleTracker.Api.Models;

namespace MotorcycleTracker.Api.Controllers;

[ApiController]
[Route("api/motorcycles")]
public class MotorcycleController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Motorcycle>> GetMotorcycles()
    {
        var motorcycles = new List<Motorcycle>
        {
            new Motorcycle { Id = 1, Make = "Kawasaki", Model = "Ninja 500 KRT", Year = 2024, Color = "Green", Mileage = 10500 }
        };

        return Ok(motorcycles);
    }
}