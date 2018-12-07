using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApplication.Entities
{
    public class ClassRoom
    {
        #region "Properties"
        //Fields 
        private int _Id;
        private int _Number;
        private string _Name;

        //relations
        public virtual ICollection<Student> ListStudents { get; set; }
        #endregion

        #region "Accessors"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get => _Id; set => _Id = value; }
        public int Number { get => _Number; set => _Number = value; }
        public string Name { get => _Name; set => _Name = value; }
        #endregion  
    }
}