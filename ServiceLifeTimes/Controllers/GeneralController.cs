using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLifeTimes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneralController : ControllerBase
    {
        public readonly IRandomNumGenerator _randomNumGenerator;
        public readonly IRandomNumGenerator2 _randomNumGenerator2;

        public GeneralController(IRandomNumGenerator randomNumGenerator, IRandomNumGenerator2 randomNumGenerator2)
        {
            _randomNumGenerator = randomNumGenerator;
            _randomNumGenerator2 = randomNumGenerator2;
        }

        [HttpGet]
        public string Get()
        {
            int randomNumber1 = _randomNumGenerator.RandomNumber;
            int randomNumber2 = _randomNumGenerator2.RandomNumGenerator();

            return $"RandomNumGenerator.RandomNumber: {randomNumber1} / RandomNumGenerator2 => RandomNumGenerator.RandomNumber2: {randomNumber2}";
        }
    }
}
