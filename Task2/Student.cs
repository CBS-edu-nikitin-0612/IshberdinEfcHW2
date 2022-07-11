using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Task2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public List<Subscrube> Subscrubes { get; set; }

        public Student()
        {
            Courses = new List<Course>();
            Subscrubes = new List<Subscrube>();
        }
    }
}