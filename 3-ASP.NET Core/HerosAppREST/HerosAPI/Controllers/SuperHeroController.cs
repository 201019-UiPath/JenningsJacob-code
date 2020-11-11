using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerosDB.Models;
using HerosLib;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private IHeroService _heroService;
        public SuperHeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }
        [HttpGet("get")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        //[Produces("application/xml")]
        //[FormatFilter]
        public IActionResult GetAllHeroes()
        {
            try
            {
                return Ok(_heroService.GetAllHeroes());
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpGet("get/{name}")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetHeroByName(string name)
        {
            try
            {
                return Ok(_heroService.GetHeroByName(name));
            } catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult AddHero(SuperHero superHero)
        {
            try
            {
                _heroService.AddHero(superHero);
                return CreatedAtAction("AddHero", superHero);
            } catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
