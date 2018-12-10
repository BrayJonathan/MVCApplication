using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApplication.Entities;


namespace MVCApplication.ViewModels.Mappings
{
    public static class Map
    {
        #region Student
        /// <summary>
        /// Convert Student to StudentViewModel
        /// </summary>
        /// <param name="student"></param>
        /// <returns>StudentViewModel</returns>
        public static StudentViewModel MapToStudentViewModel(this Student student)
        {
            List<ClassRoomViewModel> ListClassRoomViewModels = new List<ClassRoomViewModel>();
            var studentViewModel = new StudentViewModel();
            if(student == null)
            {
                return studentViewModel;
            }
            if(student.ListClassRooms.Count > 0)
            {
                foreach(ClassRoom classRoom in student.ListClassRooms)
                {
                    ClassRoomViewModel classRoomVM = new ClassRoomViewModel();
                    classRoomVM = MapToClassRoomViewModel(classRoom);
                    ListClassRoomViewModels.Add(classRoomVM);
                }
            }
            studentViewModel = new StudentViewModel()
            {
                Id = student.Id,
                Name = student.Name,
                ListClassRooms = ListClassRoomViewModels
            };
            return studentViewModel;
        }

        /// <summary>
        /// Convert StudentViewModel to Student
        /// </summary>
        /// <param name="studentViewModel"></param>
        /// <returns></returns>
        public static Student MapToStudent(this StudentViewModel studentViewModel)
        {
            List<ClassRoom> listClassRoom = new List<ClassRoom>();
            var student = new Student();
            if(studentViewModel == null)
            {
                return student;
            }
            if(studentViewModel.ListClassRooms.Count > 0)
            {
                foreach(ClassRoomViewModel classRoomVM in studentViewModel.ListClassRooms)
                {
                    ClassRoom classRoom = new ClassRoom();
                    classRoom = MapToClassRoom(classRoomVM);
                    listClassRoom.Add(classRoom);
                }
            }
            student = new Student()
            {
                Id = studentViewModel.Id,
                Name = studentViewModel.Name,
                ListClassRooms = listClassRoom

            };
            return student;
        }
        #endregion

        #region ClassRoom
        /// <summary>
        /// Convert ClassRoom to ClassRoomViewModel
        /// </summary>
        /// <param name="classRoom"></param>
        /// <returns>ClassRoomViewModel</returns>
        public static ClassRoomViewModel MapToClassRoomViewModel(this ClassRoom classRoom)
        {
            List<StudentViewModel> studentVMs = new List<StudentViewModel>();
            var classRoomViewModel = new ClassRoomViewModel();
            if(classRoom == null)
            {
                return classRoomViewModel;
            }
            if(classRoom.ListStudents.Count > 0)
            {
                foreach(Student s in classRoom.ListStudents)
                {
                    StudentViewModel sMV = new StudentViewModel();
                    sMV = MapToStudentViewModel(s);
                    studentVMs.Add(sMV);
                }
            }
            classRoomViewModel = new ClassRoomViewModel()
            {
                Id = classRoom.Id,
                Number = classRoom.Number,
                Name = classRoom.Name,
                ListStudents = studentVMs
            };
            return classRoomViewModel;
        }

        /// <summary>
        /// Convert ClassRoomViewModel to ClassRoom
        /// </summary>
        /// <param name="classRoomViewModel"></param>
        /// <returns>ClassRoom</returns>
        public static ClassRoom MapToClassRoom(this ClassRoomViewModel classRoomViewModel)
        {
            List<Student> students = new List<Student>();
            var classRoom = new ClassRoom();
            if(classRoomViewModel == null)
            {
                return classRoom;
            }
            if(classRoom.ListStudents.Count > 0)
            {
                foreach(StudentViewModel sMV in classRoomViewModel.ListStudents)
                {
                    Student s = new Student();
                    s = MapToStudent(sMV);
                    students.Add(s);
                }
            }
            classRoom = new ClassRoom()
            {
                Id = classRoomViewModel.Id,
                Number = classRoomViewModel.Number,
                Name = classRoomViewModel.Name,
                ListStudents = students
            };
            return classRoom;
        }
        #endregion

        #region Attendance
        /// <summary>
        /// Convert Attendance to StudentAttendanceViewModel
        /// </summary>
        /// <param name="attendance"></param>
        /// <returns>StudentAttendanceViewModel</returns>
        public static StudentAttendanceViewModel MapToStudentAttendanceViewModel(this Attendance attendance)
        {
            StudentAttendanceViewModel studentAttendanceViewModel = new StudentAttendanceViewModel();
            if(attendance == null)
            {
                return studentAttendanceViewModel;
            }

            studentAttendanceViewModel = new StudentAttendanceViewModel()
            {
                Id = attendance.Id,
                Date = attendance.Date,
                IsPresent = attendance.IsPresent,
                ClassRoom = attendance.ClassRoom == null ? new ClassRoomViewModel() : MapToClassRoomViewModel(attendance.ClassRoom),
                Student = attendance.Student == null ? new StudentViewModel() : MapToStudentViewModel(attendance.Student)
            };
            return studentAttendanceViewModel;
        }

        /// <summary>
        /// Convert StudentAttendanceViewModel to Attendance
        /// </summary>
        /// <param name="studentAttendanceViewModel"></param>

        /// <returns>Attendance</returns>
        public static Attendance MapToAttendance(this StudentAttendanceViewModel studentAttendanceViewModel)
        {
            Attendance attendance = new Attendance();
            if(studentAttendanceViewModel == null)
            {
                return attendance;
            }

            attendance = new Attendance()
            {
                Id = studentAttendanceViewModel.Id,
                Date = studentAttendanceViewModel.Date,
                IsPresent = studentAttendanceViewModel.IsPresent,
                ClassRoomId = studentAttendanceViewModel.ClassRoom.Id,
                StudentId = studentAttendanceViewModel.Student.Id
            };
            return attendance;
        }
        #endregion
    }
}
