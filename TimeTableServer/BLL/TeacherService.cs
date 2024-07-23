using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel.ModelsDto;

namespace BLL
{
   public class TeacherService
        
    {

        private ScechualDbContext _context;
        private readonly IMapper _mapper;



        public TeacherService(
        ScechualDbContext context,
        IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<Teacher> _items = new List<Teacher>();

        public IEnumerable<Teacher> GetAll()
        {
            return _context.teacher.ToList();
        }




        //    static teacher
        //    public TeacherService()
        //    {


        //    }
        //    public List<TeacherDto> GetMembers()
        //    {
        //        return <List<Teacherdto>>();
        //    }

        //    public TeacherDto GetMemberById(string id)
        //    {
        //        return mapperConfig.Map<Membersdto>(teachers.Find(m => m.MemberId == id).ToList().FirstOrDefault());
        //    }

        //    public void AddTeacher(TeacherDto teacher)
        //    {
        //        members.InsertOne(mapperConfig.Map<Members>(member));
        //    }

        //    public void UpdateTeacher(TeacherDto teacher)
        //    {
        //        var a = mapperConfig.Map<Members>(member);

        //        teachers.ReplaceOne(t => t.MemberId == member.MemberId, a);
        //    }

        //    public void DeleteTeacher(string id)
        //    {
        //        teachers.DeleteOne(m => m.MemberId == id);
        //    }
    }
}
