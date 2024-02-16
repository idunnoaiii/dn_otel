using Microsoft.AspNetCore.Mvc;

namespace service_b.Controllers;

[ApiController]
[Route("/api/service-b")]
public class ServiceBController : ControllerBase
{
    private readonly ILogger<ServiceBController> _logger;

    public ServiceBController(ILogger<ServiceBController> logger)
    {
        _logger = logger;
    }

    [HttpGet("run-b")]
    public ValueTask<string> Get()
    {
        return ValueTask.FromResult("This is b");
    }
}
