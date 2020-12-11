﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Services;
using E_comerce.Setting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_comerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private readonly Datacontextcs _context;
        private ICategorieService _CategorieService;

        public CategorieController (Datacontextcs context , ICategorieService categorieService) 
        {
            _context = context;
            _CategorieService = categorieService;
        }

        [AllowAnonymous]
        [HttpGet("allcateg")]
        public IActionResult Getall()
        {
            var categorie = _CategorieService.GetAll();
            System.Diagnostics.Debug.WriteLine(categorie);

            return Ok(categorie);

        }


      
        [HttpPost("createCat")]
        public IActionResult Create([FromBody]Categorie categorie)
        {
      
            try
            {
                // create user
                _CategorieService.creatcat(categorie);
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