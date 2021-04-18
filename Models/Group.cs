using System.Collections.Generic;
using System.ComponentModel;

namespace AndrewApp.Models
{
    public class Group
    {
        public int Id { get; set; }

        [DisplayName("Specjalizacja")]
        public int SpecialisationId { get; set; }

        [DisplayName("Wydział")]
        public int DepartmentId { get; set; }

        [DisplayName("Nazwa grupy")]
        public string Name { get; set; }

        [DisplayName("Specjalizacja")]
        public Specialisation Specialisation { get; set; }

        [DisplayName("Wydział")]
        public Department Department { get; set; }

        public ICollection<GroupStudent> Students { get; set; }
    }
}
