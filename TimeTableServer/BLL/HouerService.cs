using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Entity;

namespace BLL
{
    public class HouerService
    {
        private ScechualDbContext _context;
        private readonly IMapper _mapper;

        public HouerService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<Hour> _items = new List<Hour>();

        public IEnumerable<Hour> GetAll()
        {
            return _context.hour.ToList();

        }
    }
}
