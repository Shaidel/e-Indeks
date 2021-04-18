using System.ComponentModel;

namespace AndrewApp.Models
{
    public class Specialisation
    {
        [DisplayName("Specjalizacja")]
        public int Id { get; set; }

        [DisplayName("Wydział")]
        public int DepartmentId { get; set; }

        [DisplayName("Specjalizacja")]
        public string Name { get; set; }

        [DisplayName("Wydział")]
        public Department Department { get; set; }
    }
}