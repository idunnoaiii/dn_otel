using Microsoft.AspNetCore.Mvc;

namespace service_a.Controllers;

[ApiController]
[Route("/api/service-a")]
public class ServiceAController : ControllerBase
{
    private readonly ILogger<ServiceAController> _logger;
    private readonly HttpClient _client;

    public ServiceAController(
        ILogger<ServiceAController> logger,
        IHttpClientFactory clientFactory)
    {
        _logger = logger;
        _client = clientFactory.CreateClient("service-b");
    }

    [HttpGet("call-b")]
    public async Task<string> Get()
    {
        var resposne = await _client.GetStringAsync("api/service-b/run-b");
        return resposne;
    }
}
