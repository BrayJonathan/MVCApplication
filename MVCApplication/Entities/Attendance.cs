using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApplication.Entities
{
    public class Attendance
    {
        #region "Properties"
        //Fields
        private int _Id;
        private int _StudentId;
        private int _ClassRoomId;
        private DateTime _Date;
        private bool _IsPresent;

        //relation
        public virtual Student Student { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        #endregion

        #region "Accessors"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get => _Id; set => _Id = value; }
        [ForeignKey("Student")]
        public int StudentId { get => _StudentId; set => _StudentId = value; }
        [ForeignKey("ClassRoom")]
        public int ClassRoomId { get => _ClassRoomId; set => _ClassRoomId = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public bool IsPresent { get => _IsPresent; set => _IsPresent = value; }
        #endregion
    }
}