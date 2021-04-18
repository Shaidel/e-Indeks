using AndrewApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AndrewApp.Contexts
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }
    
        // przedmiot
        public DbSet<Class> Classes { get; set; }
        
        // kierunek
        public DbSet<Specialisation> Specialisations { get; set; }

        // wydzial
        public DbSet<Department> Departments { get; set; }

        // oceny (za projekty i przedmioty)
        public DbSet<Grade> Grades { get; set; }

        // grupy
        public DbSet<Group> Groups { get; set; }

        // wykladowcy
        public DbSet<Lecturer> Lecturers { get; set; }

        // projekty
        public DbSet<Project> Projects { get; set; }

        // studenci
        public DbSet<Student> Students { get; set; }

        public DbSet<ClassStudent> ClassStudents { get; set; }

        public DbSet<DepartmentLecturer> DepartmentLecturers { get; set; }

        public DbSet<GroupStudent> GroupStudents { get; set; }

        public DbSet<ProjectStudent> ProjectStudents { get; set; }
    }
}
