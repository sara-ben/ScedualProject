using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewModel.ModelsDto;
using BLL;
using DAL.Data;
using System.Collections;
using DAL.Models;
using AutoMapper;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/Grade")]

    public class GradeController : ControllerBase
    {
        private readonly GradeService _gradeService;
        private readonly ScechualDbContext _context;
        private readonly IMapper _mapper;


        public GradeController(GradeService gradeService, ScechualDbContext context, IMapper mapper)
        {
            _context = context;
            _gradeService = gradeService;
            _mapper = mapper;
        }


        [HttpGet("[action]")]

        public IActionResult getAllGrades()
        {
            return Ok(_gradeService.GetAll());
        }

    }
}