using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApplication.Entities;
using MVCApplication.ViewModels;
using MVCApplication.ViewModels.Mappings;

namespace MVCApplication.Map
{
    public static class Map
    {
        /// <summary>
        /// Convert Student to StudentViewModel
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static StudentViewModel MapToStudentViewModel(this Student student)
        {
            var studentViewModel = new StudentViewModel();
            if(student == null)
            {
                return studentViewModel;
            }
            studentViewModel = new StudentViewModel()
            {
                Id = student.Id,
                Name = student.Name
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
            var student = new Student();
            if(studentViewModel == null)
            {
                return student;
            }
            student = new Student()
            {
                Id = studentViewModel.Id,
                Name = studentViewModel.Name
            };

            return student;
        }
    }
}