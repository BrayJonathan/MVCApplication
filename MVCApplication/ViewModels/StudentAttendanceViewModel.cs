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
        private int _Id;
        private StudentViewModel _Student;
        private ClassRoomViewModel _ClassRoom;
        private DateTime _Date;
        private bool _IsPresent;
        #endregion

        #region Accessors
        public int Id { get => _Id; set => _Id = value; }
        [Required]
        public StudentViewModel Student { get => _Student; set => _Student = value; }
        [Required]
        public ClassRoomViewModel ClassRoom { get => _ClassRoom; set => _ClassRoom = value; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get => _Date; set => _Date = value; }
        [Required]
        public bool IsPresent { get => _IsPresent; set => _IsPresent = value; }
        #endregion
    }
}