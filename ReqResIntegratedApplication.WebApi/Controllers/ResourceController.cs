using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReqresIntegratedApplication.Integration.Services;

namespace ReqResIntegratedApplication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ResourceController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // POST api/<UserController>
        [HttpPost("AddResource")]

        public async Task<IActionResult> PostResource()
        {
            string baseUrl = "https://reqres.in/api/users";
            ResourceService resourceServices = new ResourceService(_httpClient, baseUrl);

            return Ok(resourceServices);
        }
    }
}
