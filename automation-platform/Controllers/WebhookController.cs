using Microsoft.AspNetCore.Mvc;
using automation_platform.Dtos;

namespace automation_platform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> logger;
        public WebhookController(ILogger<WebhookController> logger) 
        { 
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddWebhook(WebhookDto dto)
        {
            logger.LogInformation($"Webhook: \n Id: {dto.Id},\n Name: {dto.Name},\n Description: {dto.Description}");

            return Ok(dto);
        }
    }
}
