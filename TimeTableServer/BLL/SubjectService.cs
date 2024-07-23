using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class SubjectService
    {

        private ScechualDbContext _context;
        private readonly IMapper _mapper;



        public SubjectService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<Subject> _items = new List<Subject>();

        public IEnumerable<Subject> GetAll()
        {
            return _context.subject.ToList();
        }

    }
}
