using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModel.ModelsDto
{
    public class SubjectForCycleDto
    {
        public int Id { get; set; }
        public int IdCycle { get; set; }
        public int IdSubject { get; set; }
        public int NumberOfLessonsPerWeek { get; set; }
        public int IdTeacher { get; set; }

    }
}
