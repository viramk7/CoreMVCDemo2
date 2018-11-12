using CoreMVCDemo2.Models;
using CoreMVCDemo2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CoreMVCDemo2.Controllers
{
    public class HomeController : Controller
    {
        #region Initialization

        IEntityService<Student> _studentService;
        //IEntityService<Subject> _subjectService;
        //IEntityService<StudentModel> _studentModelService;

        public HomeController(IEntityService<Student> studentService)
        {
            _studentService = studentService;
        }

        #endregion


        // Issue 1 resolved
        // Issue 2 resolved
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }

        public IActionResult GetP1()
        {
            Thread.Sleep(5000);
            return PartialView(@"~/Views/Shared/Components/P1/Default.cshtml");
        }

        public IActionResult GetP2()
        {
            return PartialView(@"~/Views/Shared/Components/P2/Default.cshtml");
        }

        #region Helper methods

        //private void TruncateData()
        //{
        //    var students = _studentService.GetAll();
        //    _studentService.Delete(students.ToList());

        //    var subjects = _subjectService.GetAll();
        //    _subjectService.Delete(subjects.ToList());
        //}

        //private void PopulateSubjectTable()
        //{
        //    var subjects = new List<Subject>
        //    {
        //        new Subject{SubjectName= "Maths",Weightage = 5},
        //        new Subject{SubjectName= "Science",Weightage = 4},
        //        new Subject{SubjectName= "History",Weightage = 3},
        //    };

        //    _subjectService.Insert(subjects);
        //}

        //private void PopulateStudentTable()
        //{
        //    var students = new List<Student>
        //    {
        //        new Student{Name="Viram Keshwala",Contact = "9737873135"},
        //        new Student{Name="Shruti Sahay",Contact = "7990123456"},
        //        new Student{Name="Vivek Sadhu",Contact = "7990123457"},
        //        new Student{Name="Sristi ",Contact = "7990123458"},
        //    };

        //    _studentService.Insert(students);
        //}

        #endregion

    }
}
