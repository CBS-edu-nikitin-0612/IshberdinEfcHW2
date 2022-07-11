using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task2
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Subscrube> Subscrubits { get; set; }

        public Course()
        {
            Students = new List<Student>();
            Subscrubits = new List<Subscrube>();
        }
    }
}
