using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class LessonService
    {
        private ScechualDbContext _context;
        private readonly IMapper _mapper;



        public LessonService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<Lesson> _items = new List<Lesson>();

        //public async Task<List<Day>> GetAll()
        //{
        //    return await _context.day.ToListAsync();
        //}

        public IEnumerable<Lesson> GetAll()
        {
            return _context.lesson.ToList();
        }

    }
}
