using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel.ModelsDto;
using BLL;
using AutoMapper;
using DAL.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/Constrains")]
    [ApiController]
    public class ConstrainsController : ControllerBase
    {
        private readonly ConstrainsService _constrainsService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;
        public ConstrainsController(ConstrainsService constrainsService, ScechualDbContext context, IMapper mapper)
        {
            _constrainsService = constrainsService;
            _context = context;
            _mapper = mapper;

        }


        [HttpGet("[action]")]

        public IActionResult getAllConstrains()
        {
            return Ok(_constrainsService.GetAll());
        }


        //        // GET: api/<ConstrainsController>
        //        [HttpGet("[action]")]
        //        public IActionResult GetContrains()
        //        {
        //            return Ok(constrainsService.GetConstrains());
        //        }

        //        // GET api/<ConstrainsController>/5
        //        [HttpGet("[action]")]
        //        public IActionResult GetConstrainsById(string id)
        //        {
        //            return Ok(constrainsService.GetConstrainsById(id));
        //        }

        //        // POST api/<ConstrainsController>
        //        [HttpPost("[action]")]
        //        public IActionResult AddConstrains([FromBody] ConstrainsDto constrains)
        //        {
        //            constrainsService.AddConstrains(constrains);
        //            return Ok(constrainsService.GetConstrains());
        //        }

        //        // PUT api/<ConstrainsController>/5
        //        [HttpPut("[action]")]
        //        public IActionResult UpdateConstrains([FromBody] ConstrainsDto constrains)
        //        {
        //            constrainsService.UpdateConstrains(constrains);
        //            return Ok(constrainsService.GetConstrains());
        //        }

        //        // DELETE api/<ConstrainsController>/5
        //        [HttpDelete("[action]")]
        //        public IActionResult DeleteConstrains(string id)
        //        {
        //            constrainsService.DeleteConstrains(id);
        //            return Ok(constrainsService.GetConstrains());
        //        }

    }
}
