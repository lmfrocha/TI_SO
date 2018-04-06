using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_SO.Struct
{
    interface Dado : IEquatable<Dado>
    {
        new bool Equals(Dado o);
        int CompareTo(Dado o);
    }
}
