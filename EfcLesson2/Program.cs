using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Contextc db = new Contextc();
            {
                Country rus = new Country()
                {
                    Name = "Russia",
                    Citys = new List<City>()
                    {
                        new City() { Name = "Moscow" },
                        new City() { Name = "SPB" }
                    }
                };
                db.Add(rus);
                db.SaveChanges();
            }
        }
    }


    public class Country
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20), MinLength(2)]
        [Required]
        public string Name { get; set; }
        public List<City> Citys { get; set; }
        public Country()
        {
            Citys = new List<City>();
        }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
