using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SimpleController : Controller
    {
        [HttpGet]
        public string Get()
        {
            Console.WriteLine("ASD");
            return "Hello world!";
        }
    }
}