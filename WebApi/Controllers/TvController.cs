using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repoository_Interfface;
using Service_interface;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvController : ControllerBase
    {
        private readonly TvSerrvices _tvSerrvices;
        [HttpGet]
        [Route("Channel")]
        public IActionResult getChannnel()
        {
            throw new NotImplementedException();

        }
    }
}
