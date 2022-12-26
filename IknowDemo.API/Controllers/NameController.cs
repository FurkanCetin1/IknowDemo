//using IknowDemo.Business.Abstract;
//using IknowDemo.Entities;
//using Microsoft.AspNetCore.Mvc;

//namespace IknowDemo.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class NameController : ControllerBase
//    {
//        private readonly IJwtAuthenticationManager jwtAuthenticationManager;

//        public NameController(IJwtAuthenticationManager jwtAuthenticationManager)
//        {
//            this.jwtAuthenticationManager = jwtAuthenticationManager;
//        }

//        [HttpGet]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        [HttpGet("{id}", Name = "Get")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        [HttpPost("authenticate")]
//        public IActionResult Authenticate([FromBody] UserCred userCred)
//        {
//            var token = jwtAuthenticationManager.Authenticate(userCred.Username, userCred.Password);
//            if (token == null)
//            {
//                return Unauthorized();
//            }
//            return Ok(token);
//        }
//    }
//}
