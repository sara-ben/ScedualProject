using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TeacherLessons
    {
        public int Id { get; set; }
        public int IdTeacher { get; set; }
        public int IdLesson { get; set; }
    }
}
