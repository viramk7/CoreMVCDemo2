using CoreMVCDemo2.Data;
using CoreMVCDemo2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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

        public bool UpdateClassNameRemoveAllStudent(int id)
        {
            try
            {
                var classRoom = _context.ClassRoom.Include(i => i.Students)
                                     .FirstOrDefault(w =>w.Id == id);

                if (classRoom == null)
                    return false;

                classRoom.ClassName = "IT 8th";

                //classRoom.Students.Clear();

                _context.Student.RemoveRange(classRoom.Students);


                if(id == 2)
                    throw new System.Exception("Custom error"); ;

                _context.SaveChanges();
                
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool TestInsert()
        {
            var studentToAdd = new List<Student>
            {
                new Student { Name = "abc",Address2 = "abc",Contact = "123", ClassRoom = new ClassRoom{ Id = 2} }
            };

            try
            {
                entities.AddRange(studentToAdd);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
} 