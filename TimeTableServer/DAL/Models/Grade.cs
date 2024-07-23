using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
   
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCycle { get; set; }


    }
}
