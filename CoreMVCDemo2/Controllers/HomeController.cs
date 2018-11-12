using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CoreMVCDemo2.Models;
using CoreMVCDemo2.Services.Student;
using System;
using System.Collections.Generic;
using CoreMVCDemo2.Services;
using System.Linq;
using System.Threading;
using System.Data.SqlClient;

namespace CoreMVCDemo2.Controllers
{
    public class HomeController : Controller
    {
        #region Initialization

        IStudentService _studentService;
        IEntityService<ClassRoom> _classRoomService;
        //IEntityService<StudentModel> _studentModelService;

        //This is brach1 commit
        public HomeController(IStudentService studentService, IEntityService<ClassRoom> classRoomService)
        {
            _studentService = studentService;
            _classRoomService = classRoomService;
        }

        #endregion

        public IActionResult Index()
        {

            var result = _studentService.UpdateClassNameRemoveAllStudent(2);

            IEnumerable<Student> clssRooms; 
            if (!result)
                clssRooms = _studentService.GetAll().ToList();

            var student = new Student();

            return View(student);
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
