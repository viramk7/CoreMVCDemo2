using CoreMVCDemo2.Models.BaseEntity;
using System.Collections.Generic;

namespace CoreMVCDemo2.Models
{
    public class ClassRoom : Entity<int>
    {
        public string ClassName { get; set; }

        public IList<Student> Students { get; set; }
    }

    public class Student : Entity<long>
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address2 { get; set; }

        public ClassRoom ClassRoom { get; set; }

        //public List<Subject> Subjects { get; set; }
    }

    //public class Subject : Entity<int>
    //{
    //    public string SubjectName { get; set; }
    //    public double Weightage { get; set; }
    //}

    //public class StudentSubjectMapping : Entity<long>
    //{
    //    public Student Student { get; set; }

    //    public Subject Subject { get; set; }
    //}

    //public class StudentSubjectMapping 
    //{
    //    public long StudentId { get; set; }
    //    public int SubjectId { get; set; }

    //    public Student Student { get; set; }
    //    public Subject Subject { get; set; }
    //}

    //public class StudentModel : Entity<long>
    //{
    //    public string Name { get; set; }
    //}

}
