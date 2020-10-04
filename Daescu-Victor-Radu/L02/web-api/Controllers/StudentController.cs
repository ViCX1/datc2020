using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static readonly string[] Specializari = new[]
        {
            "IS", "CTI-ro", "CTI-eng", "ETC-ro", "ETC-eng"
        };

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            // _logger = logger;
        }

        StudentRepo Studentsr=new StudentRepo();


        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return Studentsr.Students;
        }

        [HttpPost]
       public string Insert([FromBody]string s)
       {

           return s;
       }
    }
}
