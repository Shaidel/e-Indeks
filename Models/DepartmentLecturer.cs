namespace AndrewApp.Models
{
    public class DepartmentLecturer
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public int LecturerId { get; set; }

        public Department Department { get; set; }

        public Lecturer Lecturer { get; set; }
    }
}
