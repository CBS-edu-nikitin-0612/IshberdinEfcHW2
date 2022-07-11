using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Task2
{
    public class Subscrube
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public Subscrube()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
    }
}