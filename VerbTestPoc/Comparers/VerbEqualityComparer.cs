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
            return (x.Id == y.Id);
        }

        public int GetHashCode(Verb obj)
        {
            return obj.Id;
        }
    }
}
