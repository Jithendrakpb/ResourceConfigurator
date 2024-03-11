using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResourceConfigurator.Helper;
using ResourceConfigurator.Models;

namespace ResourceConfigurator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ResourceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync(string subscriptionId, string resourceGroupName)
        {
            string baseUri = "https://management.azure.com";
            string authToken = "";
            string url = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}" +
                $"/providers/Microsoft.Compute/virtualMachines?api-version=2023-09-01";
            RestClient<Root> restClient = new RestClient<Root>(baseUri, authToken);
            var result = await restClient.GetAsync(url);
            return (IActionResult)result;
        }

    }
}
