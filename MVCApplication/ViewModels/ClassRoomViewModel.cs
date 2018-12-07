using System;
using System.Collections.Generic;
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
        #endregion

        #region "Accessors"
        public int Id { get => _Id; set => _Id = value; }
        public int Number { get => _Number; set => _Number = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string NumberName { get => _NumberName; set => _NumberName = value; }
        #endregion
    }
}