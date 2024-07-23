using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SubjectForCycle
    {
        public int Id { get; set; }
        public int IdCycle { get; set; }
        public int idSubject { get; set; }
        public int NumberOfLessonsPerWeek { get; set; }
        public int idTeacher { get; set; }

    }
}
