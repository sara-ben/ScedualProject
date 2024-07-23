using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Constrains
    {
        [Key]

        public int idConstrain { get; set; }
        public int IdTeacher { get; set; }
        public int IdDay { get; set; }
        public int IdHour { get; set; }
    }
}
