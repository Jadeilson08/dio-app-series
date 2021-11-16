using Microsoft.AspNetCore.Mvc;
using Series.Application.Service.Series;

namespace Series.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class SerieController : ControllerBase
    {
        private readonly ISrSerie _srSerie;
        public SerieController(ISrSerie srSerie)
        {
            _srSerie = srSerie;
        }

        [HttpGet]
        public IActionResult Get(){
            return Ok(_srSerie.GetAll());
        }
        
    }
}