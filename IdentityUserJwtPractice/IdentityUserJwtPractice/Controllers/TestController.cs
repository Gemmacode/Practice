using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AJIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "ClinBaby ";
        }
    }
}
