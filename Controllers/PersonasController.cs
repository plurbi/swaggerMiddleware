using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace swaggerMiddleware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonasController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
"Patricio", "Paola", "Helena", "Natalia"
        };

        private readonly ILogger<PersonasController> _logger;

        public PersonasController(ILogger<PersonasController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("getPersonas")]
        public IEnumerable<PersonaDTO> Get()
        {
            return Enumerable.Range(1, Summaries.Length).Select(index =>
               new PersonaDTO()
               {
                   Id = index,
                   Name = Summaries[index - 1]
               }
            ).ToArray();
        }
        [HttpPost]
        [Route("PostParametro")]
        public PersonaDTO SaveParametro(ParametrosDTO parametro)
        {
            return new PersonaDTO()
            {
                Id = 1,
                Name = "Patricio"
            };
        }
    }
}
