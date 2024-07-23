using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel.ModelsDto;
using BLL;
using AutoMapper;
using DAL.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Subject")]
   
    public class SubjectController : ControllerBase
    {
        private readonly SubjectService _subjectService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;

       

        public SubjectController(SubjectService subjectService, ScechualDbContext context, IMapper mapper)
        {
            _context = context;
            _subjectService = subjectService;
            _mapper = mapper;
        }

        [HttpGet("[action]")]

        public IActionResult getAllServices()
        {
            return Ok(_subjectService.GetAll());
        }


        // GET: api/<SubjectController>
        //[HttpGet("[action]")]
        //public IActionResult GetSubject()
        //{
        //    return Ok(subjectService.GetSubject());
        //}

        //// GET api/<SubjectController>/5
        //[HttpGet("[action]")]
        //public IActionResult GetSubjectById(string id)
        //{
        //    return Ok(subjectService.GetSubjectById(id));
        //}

        //// POST api/<SubjectController>
        //[HttpPost("[action]")]
        //public IActionResult AddSubject([FromBody] SubjectDto subject)
        //{
        //    subjectService.AddSubject(subject);
        //    return Ok(subjectService.GetSubject());
        //}

        //// PUT api/<SubjectController>/5
        //[HttpPut("[action]")]
        //public IActionResult UpdateSubject([FromBody] SubjectDto subject)
        //{
        //    subjectService.UpdateSubject(subject);
        //    return Ok(subjectService.GetSubject());
        //}

        //// DELETE api/<SubjectController>/5
        //[HttpDelete("[action]")]
        //public IActionResult DeleteSubject(string id)
        //{
        //    subjectService.DeleteSubject(id);
        //    return Ok(subjectService.GetSubject());
        //}

    }
}