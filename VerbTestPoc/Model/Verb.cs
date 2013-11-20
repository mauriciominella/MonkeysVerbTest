using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.Common;

namespace VerbTestPoc.Model
{
    public class Verb
    {
        #region Properties

        [Key]
        public int VerbId { get; set; }

        public int VerbLevelId { get; set; }

        public bool Active { get; set; }

        public virtual VerbLevel Level { get; set; }

        public string Infinitive { get; set; }

        #endregion

    }
}
