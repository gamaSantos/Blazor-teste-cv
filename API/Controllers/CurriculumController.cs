using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Curriculum.Domain;

namespace Curriculum.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurriculumController : ControllerBase
    {
        [HttpGet]
        public Domain.Curriculum Get()
        {
            return Domain.Builder.Build();
        }
    }
}