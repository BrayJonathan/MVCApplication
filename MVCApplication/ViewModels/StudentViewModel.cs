using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication.ViewModels.Mappings
{
    public class StudentViewModel
    {
        #region "Properties"
        private int _Id;
        private string _Name;
        private ICollection<ClassRoomViewModel> _ListClassRooms;
        #endregion

        #region "Accessor"
        [Required]
        public int Id { get => _Id; set => _Id = value; }
        [Required, StringLength(50), Display(Name = "Nom")]
        public string Name { get => _Name; set => _Name = value; }
        public ICollection<ClassRoomViewModel> ListClassRooms { get => _ListClassRooms; set => _ListClassRooms = value; }
        #endregion

    }
}