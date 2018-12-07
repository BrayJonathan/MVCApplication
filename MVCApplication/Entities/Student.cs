using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApplication.Entities
{
    public class Student
    {
        #region "Properties"
        //Fields
        private int _Id;
        private string _Name;

        //relations
        public virtual ICollection<ClassRoom> ListClassRooms { get; set; }
        #endregion

        #region "Accessor"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        #endregion


    }
}