using System;
using System.Threading.Tasks;
using Location.Models;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Location.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IRequestClient<GeocodeRequest> _requestClient;

        public LocationController(IRequestClient<GeocodeRequest> requestClient)
        {
            _requestClient = requestClient;
        }

        [HttpPost]
        public async Task<IActionResult> GeocodeLocation(GeocodeRequest req)
        {
            var response = await _requestClient.GetResponse<GeocodeResponse>(req);
            return Ok(response.Message);
        }
    }
}
