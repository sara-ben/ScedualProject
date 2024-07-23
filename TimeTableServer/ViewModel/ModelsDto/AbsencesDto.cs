using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModel.ModelsDto
{
    public class AbsencesDto
    {
        public int Id { get; set; }
        public int IdTeacher { get; set; }
        public int IdLesson { get; set; }
        public int IdCycle { get; set; }
        public DateTime Date { get; set; }
    }
}
