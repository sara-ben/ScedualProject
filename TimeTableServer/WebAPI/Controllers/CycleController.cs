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
//    public class CycleController : ControllerBase
//    {
//        private readonly CycleService cycleService;
//        private object _context;

//        public CycleController(CycleService cycleService)
//        {
//            this.cycleService = cycleService;
//        }


//        // GET: api/<CycleController>
//        [HttpGet("[action]")]
//        public IActionResult GetCycle()
//        {
//            return Ok(cycleService.GetCycle());
//        }

//        // GET api/<CycleController>/5
//        [HttpGet("[action]")]
//        public IActionResult GetCycleById(string id)
//        {
//            return Ok(cycleService.GetCycleById(id));
//        }

//        // POST api/<CycleController>
//        [HttpPost("[action]")]
//        public IActionResult AddCycle([FromBody] CycleDto cycle)
//        {
//            cycleService.AddCycle(cycle);
//            return Ok(cycleService.GetCycle());
//        }

//        // PUT api/<CycleController>/5
//        [HttpPut("[action]")]
//        public IActionResult UpdateCycle([FromBody] CycleDto cycle)
//        {
//            cycleService.UpdateCycle(cycle);
//            return Ok(cycleService.GetCycle());
//        }

//        // DELETE api/<CycleController>/5
//        [HttpDelete("[action]")]
//        public IActionResult DeleteCycle(string id)
//        {
//            cycleService.DeleteCycle(id);
//            return Ok(cycleService.GetCycle());
//        }

//    }
//}