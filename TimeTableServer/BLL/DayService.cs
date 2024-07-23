using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DayService
    {
        private ScechualDbContext _context;
        private readonly IMapper _mapper;

      

        public DayService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<Day> _items = new List<Day>();

        public IEnumerable<Day> GetAll()
        {
            return _context.day.ToList();
        }

    }
}
