using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;

namespace TheKitchenMess.Controllers
{
    [ApiController]
    [Route("ap1/v1/health")]
    public class HealthController: Controller
    {
        private readonly HealthCheckService _healthCheckService;
        public HealthController(HealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

  
        [HttpGet]
        [SwaggerOperation(OperationId = "Health_Get")]
        public async Task<IActionResult> Get()
        {
            HealthReport report = await _healthCheckService.CheckHealthAsync();
            var result = new
            {
                status = report.Status.ToString(),
                errors = report.Entries.Select(e => new
                {
                    name = e.Key,
                    status = e.Value.Status.ToString(),
                    description = e.Value.Description!.ToString()
                })
            };
            
            return report.Status == HealthStatus.Healthy ? Ok(result) : StatusCode((int)HttpStatusCode.ServiceUnavailable, report);
        }
    }
}

