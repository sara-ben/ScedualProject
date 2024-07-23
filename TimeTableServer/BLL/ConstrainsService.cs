using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ConstrainsService
    {

        private ScechualDbContext _context;
        private readonly IMapper _mapper;



        public ConstrainsService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<Constrains> _items = new List<Constrains>();


        public IEnumerable<Constrains> GetAll()
        {
            return _context.constrains.ToList();
        }

    }
}


