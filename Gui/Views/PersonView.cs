using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui
{
    public class PersonView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public float Salary { get; set; }
        public string YearsOfExperience { get; set; }
        public DateTime HiredDate { get; set; }
        public String Address { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PersonView(Person person)
        {
            Id = person.Id;
            FirstName = person.FirstName;
            LastName = person.LastName;
            JobTitle = person.JobTitle;
            Salary= person.Salary;
            YearsOfExperience = person.YearsOfExperience;
            HiredDate= person.HiredDate;
            Address = person.Address;
            Email = person.Email;
            DateOfBirth = person.DateOfBirth;

        }
    }
}
