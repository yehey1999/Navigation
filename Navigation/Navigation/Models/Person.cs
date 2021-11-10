using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation.Models
{
    public class Person
    {
        private List<string> skills = new List<string>();

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string MiddleName
        {
            get;
            set;
        }

        public string Birthday
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public string Elementary
        {
            get;
            set;
        }

        public string YearElementary
        {
            get;
            set;
        }

        public string HighSchool
        {
            get;
            set;
        }

        public string YearHighSchool
        {
            get;
            set;
        }

        public string College
        {
            get;
            set;
        }

        public List<string> Skills
        {
            get => skills;
            set => skills = value;
        }

    }
}
