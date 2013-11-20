using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerbTestPoc.Model;

namespace VerbTestPoc.Comparers
{
    public class VerbEqualityComparer : IEqualityComparer<Verb>
    {
        public bool Equals(Verb x, Verb y)
        {
            return (x.VerbId == y.VerbId);
        }

        public int GetHashCode(Verb obj)
        {
            return obj.VerbId;
        }
    }
}
