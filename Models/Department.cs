using System.ComponentModel;

namespace AndrewApp.Models
{
    public class Department
    {
        public int Id { get; set; }

        [DisplayName("Wydział")]
        public string Name { get; set; }
    }
}