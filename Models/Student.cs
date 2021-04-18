using System.Collections.Generic;
using System.ComponentModel;

namespace AndrewApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("Wydział")]
        public int? DepartmentId { get; set; }

        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Numer indeksu")]
        public string IndexNumber { get; set; }

        [DisplayName("Wydział")]
        public Department Department { get; set; }

        public ICollection<GroupStudent> Groups { get; set; }

        public ICollection<ClassStudent> Classes { get; set; }

        public ICollection<ProjectStudent> Students { get; set; }

        [DisplayName("Student")]
        public virtual string FullName => FirstName + " " + LastName;
    }
}
