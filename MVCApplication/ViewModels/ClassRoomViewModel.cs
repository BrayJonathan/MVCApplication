using MVCApplication.ViewModels.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication.ViewModels
{
    public class ClassRoomViewModel
    {
        #region "Properties"
        private int _Id;
        private int _Number;
        private string _Name;
        private string _NumberName;
        private ICollection<StudentViewModel> _ListStudents;
        #endregion

        #region "Accessors"
        public int Id { get => _Id; set => _Id = value; }
        [Required]
        public int Number { get => _Number; set => _Number = value; }
        [Required]
        public string Name { get => _Name; set => _Name = value; }
        [Required]
        public string NumberName { get => _NumberName; set => _NumberName = value; }
        public ICollection<StudentViewModel> ListStudents { get => _ListStudents; set => _ListStudents = value; }
        #endregion
    }
}