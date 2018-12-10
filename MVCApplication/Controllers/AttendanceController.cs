using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Entities;
using MVCApplication.ViewModels;
using MVCApplication.ViewModels.Mappings;

namespace MVCApplication.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: Attendance
        public ActionResult Index()
        {
            return View("StudentAttendanceIndex");
        }


        public ActionResult Create()
        {
                List<StudentViewModel> students = new List<StudentViewModel>();
                for(int i = 1; i <= 10; i++)
                {
                    StudentViewModel student = new StudentViewModel()
                    {
                        Id = i,
                        Name = "Nom" + i.ToString()
                    };
                    students.Add(student);
                }

                List<ClassRoomViewModel> classRooms = new List<ClassRoomViewModel>();
                ClassRoomViewModel classRoom = new ClassRoomViewModel()
                {
                    Id = 1,
                    Name = "Salle101",
                    Number = 101,
                    ListStudents = students
                };
                classRooms.Add(classRoom);
                ViewBag.StudentList = students.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).AsEnumerable();
                ViewBag.ClassRoomList = classRooms.Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).AsEnumerable();
                return View("AddStudentAttendance");
              
        }
    } 
}