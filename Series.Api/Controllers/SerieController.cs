using Microsoft.AspNetCore.Mvc;
using Series.Application.Service.Series;
using Series.Infra.Transport.Input;

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
        public IActionResult Get()
        {
            return Ok(_srSerie.GetAll());
        }

        [HttpGet("genres")]
        public IActionResult GetGenres()
        {
            return Ok(_srSerie.GetGeneros());
        }

        [HttpPost]
        public IActionResult Post([FromBody] SerieInput serie)
        {
            var isCreated = _srSerie.Create(serie);
            return Ok(isCreated);
        }

    }
}