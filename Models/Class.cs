using System.Collections.Generic;
using System.ComponentModel;

namespace AndrewApp.Models
{
    [DisplayName("Przedmiot")]
    public class Class
    {
        public int Id { get; set; }

        [DisplayName("Wydział")]
        public int DepartmentId { get; set; }

        [DisplayName("Wykładowca")]
        public int LecturerId { get; set; }

        [DisplayName("Przedmiot")]
        public string Name { get; set; }

        [DisplayName("Wydział")]
        public Department Department { get; set; }

        [DisplayName("Wykładowca")]
        public Lecturer Lecturer { get; set; }

        public ICollection<ClassStudent> Students { get; set; }
    }
}