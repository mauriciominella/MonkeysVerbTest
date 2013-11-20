using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbTestPoc.Model
{
    public class VerbLevel
    {
        [Key]
        public int VerbLevelId { get; set; }

        public string Name { get; set; }
    }
}
