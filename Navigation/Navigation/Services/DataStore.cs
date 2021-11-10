using Navigation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation.Services
{
    public class DataStore : IDataStore
    {
        public Person Person
        {
            get;
            set;
        }

        public DataStore()
        {
            Person = new Person();
        }

        public void UpdatePersonInfo(string firstName, string lastName, string middleName, string birthday, string gender)
        {
            Person.FirstName = firstName;
            Person.LastName = lastName;
            Person.MiddleName = middleName;
            Person.Birthday = birthday;
            Person.Gender = gender;
        }

        public void UpdateEducationBackground(string elementary, string yearElementary, string highSchool, string yearHighSchool, string college)
        {
            Person.Elementary = elementary;
            Person.YearElementary = yearElementary;
            Person.HighSchool = highSchool;
            Person.YearHighSchool = yearHighSchool;
            Person.College = college;
        }

        public void AddSkill(string skill)
        {
            Person.Skills.Add(skill);
        }

        public Person GetPerson()
        {
            return Person;
        }

    }
}
