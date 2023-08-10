using Microsoft.AspNetCore.Mvc;

namespace TallerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get(){
        string[] nombres = new[]{"Fabian", "Rolando", "Tatiana", "Luis", "Andres", "Karen", "Javier", "Kevin", "Esteban"};
        return nombres;
    }
}