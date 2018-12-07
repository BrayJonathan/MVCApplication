using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCApplication.Entities; 

namespace MVCApplication.ViewModels.Mappings
{
    public class StudentAttendanceViewModel
    {
        #region Properties
        private StudentViewModel _Student;
        private ClassRoomViewModel _ClassRoom;
        private DateTime _Date;
        private bool _IsPresent;
        #endregion

        #region Accessors
        public StudentViewModel Student { get => _Student; set => _Student = value; }
        public ClassRoomViewModel ClassRoom { get => _ClassRoom; set => _ClassRoom = value; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get => _Date; set => _Date = value; }
        public bool IsPresent { get => _IsPresent; set => _IsPresent = value; }
        #endregion
    }
}