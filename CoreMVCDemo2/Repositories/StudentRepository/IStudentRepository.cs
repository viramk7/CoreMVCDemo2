using CoreMVCDemo2.Models;
using System.Collections.Generic;

namespace CoreMVCDemo2.Repositories.StudentRepository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Student GetById(long id);
    }
}
