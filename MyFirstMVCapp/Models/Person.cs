﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCapp.Models
{
    public class Person
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth_Year { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        // Creating a list builder dependent on two parameters, beginning search year and end search year
        public List<Person> People(int begYear, int endYear)
        {
            //creating that list
            List<Person> people = new List<Person>();
            // looks into the websites (servers) directory for the file
            string path = Environment.CurrentDirectory;
            // combines the path to the website files, then directs the path to the specific personOfTheYear file
            string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\personOfTheYear.csv"));
            // a string array, thats going to hold all our Persons, every single one
            string[] myFile = File.ReadAllLines(newPath);

            for (int i = 1; i < myFile.Length; i++)
            {
                string[] fields = myFile[i].Split(',');
                people.Add(new Person
                {
                    Year = Convert.ToInt32(fields[0]),
                    Honor = fields[1],
                    Name = fields[2],
                    Country = fields[3],
                    Birth_Year = (fields[4] == "") ? 0 : Convert.ToInt32(fields[4]),
                    DeathYear = (fields[5] == "") ? 0 : Convert.ToInt32(fields[5]),
                    Title = fields[6],
                    Category = fields[7],
                    Context = fields[8],
                });
            }

            


            // reduces that list from above to ones that fit our search fields
            List<Person> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();
            return listofPeople;
        }

    }
    
}
