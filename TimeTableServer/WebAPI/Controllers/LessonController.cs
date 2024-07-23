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
    [Route("api/Lesson")]
    public class LessonController : ControllerBase
    {
        private readonly LessonService _lessonService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;

        public LessonController(LessonService lessonService, ScechualDbContext context, IMapper mapper)
        {
            _context = context;
            _lessonService = lessonService;
            _mapper = mapper;
        }


        [HttpGet("[action]")]

        public IActionResult getAllLessons()
        {
            return Ok(_lessonService.GetAll());
        }

        //public LessonController(LessonService lessonService)
        //{
        //    this.lessonService = lessonService;
        //}


        //// GET: api/<LessonController>
        //[HttpGet("[action]")]
        //public IActionResult GetLesson()
        //{
        //    return Ok(lessonService.GetLesson());
        //}

        //// GET api/<LessonController>/5
        //[HttpGet("[action]")]
        //public IActionResult GetLessonById(string id)
        //{
        //    return Ok(lessonService.GetLessonById(id));
        //}

        //// POST api/<LessonController>
        //[HttpPost("[action]")]
        //public IActionResult AddLesson([FromBody] LessonDto lesson)
        //{
        //    lessonService.AddLesson(lesson);
        //    return Ok(lessonService.GetLesson());
        //}

        //// PUT api/<LessonController>/5
        //[HttpPut("[action]")]
        //public IActionResult UpdateLesson([FromBody] LessonDto lesson)
        //{
        //    lessonService.UpdateLesson(lesson);
        //    return Ok(lessonService.GetLesson());
        //}

        //// DELETE api/<LessonController>/5
        //[HttpDelete("[action]")]
        //public IActionResult DeleteLesson(string id)
        //{
        //    lessonService.DeleteLesson(id);
        //    return Ok(lessonService.GetLesson());
        //}

    }
}