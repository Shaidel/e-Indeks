namespace AndrewApp.Models
{
    public class GroupStudent
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int GroupId { get; set; }

        public Student Student { get; set; }

        public Group Group { get; set; }
    }
}
