using CoreMVCDemo2.Models.BaseEntity;

namespace CoreMVCDemo2.Models
{
    public class Student : Entity<long>
    {
        public string Name { get; set; }
        public string Contact { get; set; }
    }

    public class Subject : Entity<int>
    {
        public string SubjectName { get; set; }
        public double Weightage { get; set; }
    }

    public class StudentSubjectMapping 
    {
        public long StudentId { get; set; }
        public int SubjectId { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }

    public class StudentModel : Entity<long>
    {
        public string Name { get; set; }
    }

}
