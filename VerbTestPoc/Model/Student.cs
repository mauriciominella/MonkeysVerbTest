using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace VerbTestPoc.Model
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }

        public int Name { get; set; }
    }
}
