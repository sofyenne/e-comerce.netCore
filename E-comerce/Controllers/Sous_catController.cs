using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Services;
using E_comerce.Setting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_comerce.Controllers
{
    [Route("api/nadim")]
    [ApiController]
    public class Sous_catController : ControllerBase
    {

        private readonly Datacontextcs _context;
        private Isous_cat _souService;

        public Sous_catController(Datacontextcs context, Isous_cat SousService)
        {
            this._context = context;
            this._souService = SousService;
        }








        [HttpGet("affiche")]
        public IActionResult Getalls()
        {
            var sous = _souService.GetAllS();
            return Ok(sous);
        }



        [HttpPost("cretasous")]
        public IActionResult Create( [FromBody] Sous_cat  sous)
        {

            try
            {
                _souService.Creation(sous);
      
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}