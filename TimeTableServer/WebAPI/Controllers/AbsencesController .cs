//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using BLL;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ViewModel;
//using ViewModel.ModelsDto;

//namespace WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AbsencesController : ControllerBase
//    {

//       private readonly AbsencesService absencesService;
//        private object _context;

//        public AbsencesController(AbsencesService absencesService)
//        {
//            this.absencesService = absencesService;
//        }


//        // GET: api/<AbsencesController>
//        [HttpGet("[action]")]
//        public IActionResult GetAbsences()
//        {
//            return Ok(absencesService.GetAbsences());
//        }

//        // GET api/<AbsencesController>/5
//        [HttpGet("[action]")]
//        public IActionResult GetAbsencesById(string id)
//        {
//            return Ok(absencesService.GetAbsencesById(id));
//        }

//        // POST api/<AbsencesController>
//        [HttpPost("[action]")]
//        public IActionResult AddAbsences([FromBody] AbsencesDto absences)
//        {
//            absencesService.AddAbsences(absences);
//            return Ok(absencesService.GetAbsences());
//        }

//        // PUT api/<AbsencesController>/5
//        [HttpPut("[action]")]
//        public IActionResult UpdateAbsences([FromBody] AbsencesDto absences)
//        {
//            absencesService.UpdateAbsences(absences);
//            return Ok(absencesService.GetAbsences());
//        }

//        // DELETE api/<AbsencesController>/5
//        [HttpDelete("[action]")]
//        public IActionResult DeleteAbsences(string id)
//        {
//            absencesService.DeleteAbsences(id);
//            return Ok(absencesService.GetAbsences());
//        }
        
//    }
//}