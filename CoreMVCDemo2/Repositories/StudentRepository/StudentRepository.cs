using CoreMVCDemo2.Data;
using CoreMVCDemo2.Models;
using System.Collections.Generic;

namespace CoreMVCDemo2.Repositories.StudentRepository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentDbContext context) : base(context)
        {

        }

        public Student GetById(long id)
        {
            return entities.Find(id);
        }
    }
}
