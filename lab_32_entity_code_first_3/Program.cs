using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;

namespace lab_32_entity_code_first_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CollegeContext())
            {
                var student01 = new Student()
                {
                    StudentName = "Seb"

                };
                db.Students.Add(student01);
                db.SaveChanges();

            }
            List<Student> students = new List<Student>();
            using (var db = new CollegeContext())
            {
                students = db.Students.ToList<Student>();
            }
            students.ForEach(s =>
                Console.WriteLine($"ID: {s.StudentID} name: {s.StudentName}"));
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Qualification Qualification { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class CollegeContext : DbContext
    {
        //CONSTRUCTOR method : bounce responsibikity back up to entity DbContext tgo do all the hard work
        public CollegeContext() : base("SebCollegeDatabase") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}