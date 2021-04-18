using System.Collections.Generic;
using System.ComponentModel;

namespace AndrewApp.Models
{
    public class Lecturer
    {
        public int Id { get; set; }

        [DisplayName("Wydział")]
        public int DepartmentId { get; set; }

        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [DisplayName("Kategoria pracy")]
        public string? WorkCategory { get; set; }

        [DisplayName("Telefon")]
        public string? PhoneNumber { get; set; }

        [DisplayName("Adres e-mail")]
        public string? Mail { get; set; }

        [DisplayName("Hasło")]
        public string Password { get; set; }

        [DisplayName("Wydział")]
        public Department Department { get; set; }

        public ICollection<DepartmentLecturer> Departments { get; set; }

        [DisplayName("Wykładowca")]
        public virtual string FullName => FirstName + " " + LastName;
    }
}
