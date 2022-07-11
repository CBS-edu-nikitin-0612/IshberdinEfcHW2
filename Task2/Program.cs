using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Context db = new Context();
            {
                #region Init Data

                Student student1 = new Student() { Name = "Ilfat" };
                Student student2 = new Student() { Name = "Andrew" };

                Course course1 = new Course { Name = "ITVDN EFC" };
                Course course2 = new Course { Name = "ITVDN GIT" };
                Course course3 = new Course { Name = "ITVDN SQL" };


                Subscrube subscrube1 = new Subscrube() { Name = "Gold" };
                Subscrube subscrube2 = new Subscrube() { Name = "Silver" };

                subscrube1.Courses.AddRange(new List<Course> { course1, course2 });
                subscrube2.Courses.Add(course2);

                student1.Subscrubes.Add(subscrube1);
                student2.Subscrubes.Add(subscrube2);

                student2.Courses.Add(course3);
                db.AddRange(student1, student2, subscrube1, subscrube2, course1, course2, course3);
                db.SaveChanges();
                #endregion

                foreach (Student student in db.Students.Include(s => s.Subscrubes).ThenInclude(s => s.Courses).Include(s => s.Courses))
                {
                    foreach (var subscrube in student.Subscrubes)
                    {
                        Console.WriteLine($"Student {student.Name} have courses by subscrube {subscrube.Name}:");
                        foreach (var course in subscrube.Courses)
                        {
                            Console.WriteLine(course.Name);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Student {student.Name} have courses with out subscrube:");
                    foreach (var course in student.Courses)
                    {
                        Console.WriteLine(course.Name);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
