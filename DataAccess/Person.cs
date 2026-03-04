using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess
{
    public class Person
    {
        public int Id { get; set; }
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string? JobTitle { get; set; }
        public float Salary { get; set; }
        public string? YearsOfExperience { get; set; }
        public DateTime HiredDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Bug>? Bugs { get; set; }

        public string FullName()
        {
            return FirstName+ " " +LastName;
        }

       
    }
}