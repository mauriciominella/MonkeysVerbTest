using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerbTestPoc.Model
{
    public class Team
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public Common.Books Book { get; set; }

        public List<Student> Students { get; set; }

        public List<string> WeekDays { get; set; }
    }
}
