using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_comerce.Services;
using E_comerce.Setting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_comerce.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdmin _adminService;

        public AdminController(IAdmin adminService)
        {
            _adminService = adminService;

        }


       
        [HttpGet("getallArtisan")]
        public IActionResult GetallArtisan()
        {
            var users = _adminService.GetAllArtisan();
            return Ok(users);
        }




     
        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var users = _adminService.GetAll();
            return Ok(users.Where(x => x.Roles == "Artisan"));
        }

        

        [HttpPut("update/{id}")]
        public IActionResult Update(int id)
        {


            try
            {

                _adminService.updateuser(id);
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