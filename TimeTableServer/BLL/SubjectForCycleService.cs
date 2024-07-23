using AutoMapper;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class SubjectForCycleService
    {

        private ScechualDbContext _context;
        private readonly IMapper _mapper;

        public SubjectForCycleService(
      ScechualDbContext context,
      IMapper map)
        {
            _context = context;
            _mapper = map; ;
        }


        private readonly List<SubjectForCycle> _items = new List<SubjectForCycle>();

        public IEnumerable<SubjectForCycle> GetAll()
        {
            return _context.subjectForCycle.ToList();
        }

        //פונקציה שמקבלת כיתה ואת המערכת לאחר העריכה 
        //בודקת האם מס השעות של כל מורה בכיתה מתאים 
        //ואם כן מחזירה אוקי
        //אחרת מחזירה את אי די מורה שלא תואם מס' השעות שמלמדת לבין מה שמופיע

        public class IscedualValidate
        {
            public int teacherName { get; set; }
            public int numHourDif { get; set; }

        }

        public List<SubjectForCycle> GetAllByGrade(int cycleId)
        {
            var subject = _context.subjectForCycle.Where(s => s.IdCycle == cycleId).ToList();

            return subject;
        }


        public List<IscedualValidate> chekScedualBySubjectAmount(List<ResultTbl> scedualPerGrade, int cycleId)
        {
            List<IscedualValidate> IscedualValidateList = new List<IscedualValidate>();
            List<SubjectForCycle> subjectForCycle = GetAllByGrade(cycleId);
            subjectForCycle.ForEach(s =>
            {
                int sum = 0;
                scedualPerGrade.ForEach(r =>
                {
                    if (r.IdSubject == s.idSubject)
                    {
                        sum++;
                    }
                });
                if (sum != s.NumberOfLessonsPerWeek)
                {
                    IscedualValidate scedualValidate = new IscedualValidate
                    { teacherName = s.idTeacher, numHourDif = sum - s.NumberOfLessonsPerWeek };

                    IscedualValidateList.Add(scedualValidate);
                }
            });

            return IscedualValidateList;
        }
    }
}
