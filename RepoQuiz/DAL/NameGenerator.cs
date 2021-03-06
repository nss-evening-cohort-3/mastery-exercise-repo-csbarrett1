﻿using RepoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace RepoQuiz.DAL
{
    public class NameGenerator : StudentContext
    {
        // This class should be used to generate random names and Majors for Students.
        // This is NOT your Repository
        // All methods should be Unit Tested :)
        Random rnd1 = new Random(1);
        Random rnd2 = new Random(2);
        Random rnd3 = new Random(3);

        public Student GenerateStudent()
        {


            var firstNames = new List<string> { "Rufus", "Bear", "Dakota", "Fido",
                                "Vanya", "Samuel", "Koani", "Volodya",
                                "Prince", "Yiska" };

            var lastNames = new List<string> { "Smith", "Jones", "Adams", "Benton",
                                  "Cheng", "Diamond", "Elliott", "Fisk",
                                  "Giordano", "Holloman" };

            var majors = new List<string> { "Psychology", "Astrology", "Chemistry", "Music History",
                                  "Fine Art", "Biology", "Government", "Computer Science",
                                  "Business", "Graphic Design" };

            int first_index = rnd1.Next(firstNames.Count);
            var firstname = firstNames[first_index];
            firstNames.RemoveAt(first_index);

            int last_index = rnd2.Next(lastNames.Count);
            var lastname = lastNames[last_index];
            lastNames.RemoveAt(last_index);

            int majors_index = rnd3.Next(majors.Count);
            var major = majors[majors_index];
            majors.RemoveAt(majors_index);

            return new Student { FirstName = firstname, LastName = lastname, Major = major };

        }
    }

}