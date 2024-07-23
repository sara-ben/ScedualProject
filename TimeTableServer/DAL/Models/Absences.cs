using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Absences
    {
        public int Id { get; set; }
        public int IdTeacher { get; set; }
        public int IdLesson { get; set; }
        public int IdCycle { get; set; }
        public DateTime Date { get; set; }
    }
}
