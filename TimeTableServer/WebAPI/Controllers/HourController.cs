using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel.ModelsDto;
using BLL;
using DAL.Data;
using AutoMapper;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Hour")]

    public class HourController : ControllerBase
    {
        private readonly HouerService _houerService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;


        public HourController(HouerService houerService, ScechualDbContext context, IMapper mapper)
        {
            _context = context;
            _houerService = houerService;
            _mapper = mapper;
        }


        [HttpGet("[action]")]

        public IActionResult getAllHoures()
        {
            return Ok(_houerService.GetAll());
        }




        //private readonly HourService hourService;
        //private object _context;

        //public HourController(HourService hourService)
        //{
        //    this.hourService = hourService;
        //}


        //// GET: api/<HourController>
        //[HttpGet("[action]")]
        //public IActionResult GetHour()
        //{
        //    return Ok(hourService.GetHour());
        //}

        //// GET api/<HourController>/5
        //[HttpGet("[action]")]
        //public IActionResult GetHourById(string id)
        //{
        //    return Ok(hourService.GetHourById(id));
        //}

        //// POST api/<HourController>
        //[HttpPost("[action]")]
        //public IActionResult AddHour([FromBody] HourDto hour)
        //{
        //    hourService.AddHour(hour);
        //    return Ok(hourService.GetHour());
        //}

        //// PUT api/<HourController>/5
        //[HttpPut("[action]")]
        //public IActionResult UpdateHour([FromBody] HourDto hour)
        //{
        //    hourService.UpdateHour(hour);
        //    return Ok(hourService.GetHour());
        //}

        //// DELETE api/<HourController>/5
        //[HttpDelete("[action]")]
        //public IActionResult DeleteHour(string id)
        //{
        //    hourService.DeleteHour(id);
        //    return Ok(hourService.GetHour());
        //}

    }
}