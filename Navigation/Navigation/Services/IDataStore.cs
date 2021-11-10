using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation.Services
{
    public interface IDataStore<T>
    {
        void UpdatePersonInfo(string firstName, string lastName, string middleName, string birthday, string gender);

        void UpdateEducationBackground(string elementary, string yearElementary, string highSchool, string yearHighSchool, string college);

        void AddSkill(string skill);

        T GetPerson();
    }
}
