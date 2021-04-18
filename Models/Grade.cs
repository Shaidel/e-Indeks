using System;
using System.ComponentModel;

namespace AndrewApp.Models
{
    public class Grade
    {
        public int Id { get; set; }

        [DisplayName("Student")]
        public int StudentId { get; set; }

        [DisplayName("Projekt")]
        public int? ProjectId { get; set; }

        [DisplayName("Przedmiot")]
        public int? ClassId { get; set; }

        [DisplayName("Ocena")]
        public float Value { get; set; }

        [DisplayName("Data wpisu")]
        public DateTime? GivenAt { get; set; }

        public Student Student { get; set; }

        [DisplayName("Projekt")]
        public Project Project { get; set; }

        [DisplayName("Przedmiot")]
        public Class Class { get; set; }
    }
}
