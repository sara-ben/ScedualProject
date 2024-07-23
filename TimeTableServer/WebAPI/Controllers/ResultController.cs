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

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Result")]

    public class ResultController : ControllerBase
    {
        private readonly ResultService _resultService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;
        public ResultController(ResultService resultService, ScechualDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            this._resultService = resultService;
        }

        [HttpGet("[action]")]

        public IActionResult getAllResult()
        {
            return Ok(_resultService.GetAll());
        }

        //[HttpPost("[action]")]

        //public IActionResult chekAllResults( [FromBody] List<ResultTbl> allResults)
        //{
        //    var result = _resultService.chekAllResults(allResults);
        //    return Ok(result);
        //}

    }
}