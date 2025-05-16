using System;
using Microsoft.AspNetCore.Mvc;

namespace Layered.Presentation.Controllers;

    [ApiController]
    [Route("/api/v1/[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public string GetHelloWorld() {
        return "Hello World";
    }
}
