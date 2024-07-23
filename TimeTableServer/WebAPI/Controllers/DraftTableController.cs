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
//    public class DraftTableController : ControllerBase
//    {
//        private readonly DraftTableService draftTableService;
//        private object _context;

//        public DraftTableController(DraftTableService draftTableService)
//        {
//            this.draftTableService = draftTableService;
//        }


//        // GET: api/<DraftTableController>
//        [HttpGet("[action]")]
//        public IActionResult GetDraftTable()
//        {
//            return Ok(draftTableService.GetDraftTable());
//        }

//        // GET api/<DraftTableController>/5
//        [HttpGet("[action]")]
//        public IActionResult GetDraftTableById(string id)
//        {
//            return Ok(draftTableService.GetDraftTableById(id));
//        }

//        // POST api/<DraftTableController>
//        [HttpPost("[action]")]
//        public IActionResult AddDraftTable([FromBody] DraftTableDto draftTable)
//        {
//            draftTableService.AddDraftTable(draftTable);
//            return Ok(draftTableService.GetDraftTable());
//        }

//        // PUT api/<DraftTableController>/5
//        [HttpPut("[action]")]
//        public IActionResult UpdateDraftTable([FromBody] DraftTableDto draftTable)
//        {
//            draftTableService.UpdateDraftTable(draftTable);
//            return Ok(draftTableService.GetDraftTable());
//        }

//        // DELETE api/<DraftTableController>/5
//        [HttpDelete("[action]")]
//        public IActionResult DeleteDraftTable(string id)
//        {
//            draftTableService.DeleteDraftTable(id);
//            return Ok(draftTableService.GetDraftTable());
//        }

//    }
//}