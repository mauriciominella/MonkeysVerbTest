using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.Common;

namespace VerbTestPoc.Model
{
    public class Verb
    {
        #region Properties

        public int Id { get; set; }
        public VerbLevel Level { get; set; }
        public bool Active { get; set; }
        public Books Book { get; set; }

        #endregion
    }
}
