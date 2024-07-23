using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel.ModelsDto;
using BLL;
using DAL.Data;
using AutoMapper;
using DAL.Models;
using Newtonsoft.Json.Linq;
using System;

namespace WebAPI.Controllers
{
    [Route("api/SubjectForCycle")]
    [ApiController]
    public class SubjectForCycleController : ControllerBase
    {
        private readonly SubjectForCycleService _subjectForCycleService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;
        public SubjectForCycleController(SubjectForCycleService subjectForCycleService, ScechualDbContext context, IMapper mapper)
        {
            this._subjectForCycleService = subjectForCycleService;
            _mapper = mapper;
            _context = context;

        }

        [HttpGet("[action]")]

        public IActionResult getAllSubjectForCycle()
        {
            return Ok(_subjectForCycleService.GetAll());
        }


        [HttpPost("[action]")]

        //public IActionResult chekScedualBySubjectAmount( [FromBody] List<ResultTbl> scedualPerGrade)
        //{
        //    var result = _subjectForCycleService.chekScedualBySubjectAmount(scedualPerGrade,2);
        //    return Ok(result);
        //}

        //[Route("chekScedualBySubjectAmount/{cycleId}")]

        public IActionResult chekScedualBySubjectAmount(int cycleId, [FromBody] List<ResultTbl> scedualPerGrade)
        {
            var result = _subjectForCycleService.chekScedualBySubjectAmount(scedualPerGrade, Convert.ToInt32(cycleId));
            return Ok(result);
        }

    }
}