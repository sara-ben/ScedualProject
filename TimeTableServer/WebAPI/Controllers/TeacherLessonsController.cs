//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ViewModel.ModelsDto;
//using BLL;

//namespace WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TeacherLessonsController : ControllerBase
//    {
//        private readonly TeacherLessonsService teacherLessonsService;
//        private object _context;

//        public TeacherLessonsController(TeacherLessonsService teacherLessonsService)
//        {
//            this.teacherLessonsService = teacherLessonsService;
//        }


//        // GET: api/<TeacherLessonsController>
//        [HttpGet("[action]")]
//        public IActionResult GetTeacherLessons()
//        {
//            return Ok(teacherLessonsService.GetTeacherLessons());
//        }

//        // GET api/<TeacherLessonsController>/5
//        [HttpGet("[action]")]
//        public IActionResult GetTeacherLessonsById(string id)
//        {
//            return Ok(teacherLessonsService.GetTeacherLessonsById(id));
//        }

//        // POST api/<TeacherLessonsController>
//        [HttpPost("[action]")]
//        public IActionResult AddTeacherLessons([FromBody] TeacherLessonsDto teacherLessons)
//        {
//            teacherLessonsService.AddTeacherLessons(teacherLessons);
//            return Ok(teacherLessonsService.GetTeacherLessons());
//        }

//        // PUT api/<TeacherLessonsController>/5
//        [HttpPut("[action]")]
//        public IActionResult UpdateTeacherLessons([FromBody] TeacherLessonsDto teacherLessons)
//        {
//            teacherLessonsService.UpdateTeacherLessons(teacherLessons);
//            return Ok(teacherLessonsService.GetTeacherLessons());
//        }

//        // DELETE api/<TeacherLessonsController>/5
//        [HttpDelete("[action]")]
//        public IActionResult DeleteTeacherLessons(string id)
//        {
//            teacherLessonsService.DeleteTeacherLessons(id);
//            return Ok(teacherLessonsService.GetTeacherLessons());
//        }

//    }
//}