using AutoMapper;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.ModelsDto;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BLL
{
    public class GradeService
    {

        private ScechualDbContext _context;
        
        private readonly IMapper _mapper;



        public GradeService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<Grade> _items = new List<Grade>();

        public IEnumerable<Grade> GetAll()
        {
            return _context.grade.ToList();
        }
        
    }
}