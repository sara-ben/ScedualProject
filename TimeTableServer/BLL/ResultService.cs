using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace BLL
{
    public class ResultService
    {
        private ScechualDbContext _context;
        private readonly IMapper _mapper;

        public ResultService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map;
        }
        //public class IdulicateGrade
        //{
        //    //LessonId: result.idLesson, teacherId: result.idTeacher, grade:[result.idGrade]
        //    public int LessonId { get; set; }
        //    public int teacherId { get; set; }
        //    public Array<int> grades { get; set; }

        //}
        private readonly List<ResultTbl> _items = new List<ResultTbl>();

        public IEnumerable<ResultTbl> GetAll()
        {
            return _context.ResultTbl.ToList();
        }

        //public IEnumerable<> chekAllResults() { }
    }
}
