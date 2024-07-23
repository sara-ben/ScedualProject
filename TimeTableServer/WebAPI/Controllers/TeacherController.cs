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
    [Route("api/Teacher")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherService _teacherService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;


        public TeacherController(TeacherService teacherService, ScechualDbContext context, IMapper mapper)
        {
            _context = context;
            _teacherService = teacherService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]

        public IActionResult getAllTeacher()
        {
            return Ok(_teacherService.GetAll());
        }


        //public TeacherController(TeacherService teacherService)
        //{
        //    this.teacherService = teacherService;
        //}


        //// GET: api/<TeacherController>
        //[HttpGet("[action]")]
        //public IActionResult GetTeacher()
        //{
        //    return Ok(teacherService.GetTeacher());
        //}

        //// GET api/<TeacherController>/5
        //[HttpGet("[action]")]
        //public IActionResult GetTeacherById(string id)
        //{
        //    return Ok(teacherService.GetTeacherById(id));
        //}

        //// POST api/<TeacherController>
        //[HttpPost("[action]")]
        //public IActionResult AddTeacher([FromBody] TeacherDto teacher)
        //{
        //    teacherService.AddTeacher(teacher);
        //    return Ok(teacherService.GetTeacher());
        //}

        //// PUT api/<TeacherController>/5
        //[HttpPut("[action]")]
        //public IActionResult UpdateTeacher([FromBody] TeacherDto teacher)
        //{
        //    teacherService.UpdateTeacher(teacher);
        //    return Ok(teacherService.GetTeacher());
        //}

        //// DELETE api/<TeacherController>/5
        //[HttpDelete("[action]")]
        //public IActionResult DeleteTeacher(string id)
        //{
        //    teacherService.DeleteTeacher(id);
        //    return Ok(teacherService.GetTeacher());
        //}

    }
}