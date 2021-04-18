using System.Collections.Generic;
using System.ComponentModel;

namespace AndrewApp.Models
{
    public class Project
    {
        public int Id { get; set; }

        [DisplayName("Przedmiot")]
        public int ClassId { get; set; }

        [DisplayName("Projekt")]
        public string Subject { get; set; }

        [DisplayName("Limit uczestników")]
        public int? AttendantLimit { get; set; }

        [DisplayName("Przedmiot")]
        public Class Class { get; set; }

        public ICollection<ProjectStudent> Students { get; set; }
    }
}
