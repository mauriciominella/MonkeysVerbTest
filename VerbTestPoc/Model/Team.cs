using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace VerbTestPoc.Model
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string Name { get; set; }

        public int BookId { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<WeekDay> WeekDays { get; set; }

        public virtual Book Book { get; set; }
    }
}
