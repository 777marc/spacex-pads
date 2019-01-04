using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using spacex_pads.Models;
using spacex_pads.Services;

namespace spacex_pads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchPadsController : ControllerBase
    {
        private readonly ILaunchPads _repo;
        public LaunchPadsController(ILaunchPads repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllPads()
        {
            var launchPads = await _repo.GetAllPads();
            return Ok(launchPads);
        }
        
        [HttpGet("{id}")]
        public ActionResult<LaunchPad> Get(int id)
        {
            return _repo.GetPad(id);
        }

    }
}
