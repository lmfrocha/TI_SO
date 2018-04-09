using System;

namespace Calc_polonesa
{
    interface Dados : IEquatable<Dados>
    {
        new bool Equals(Dados o);
        int CompareTo(Dados o);
        //Leandro
    }
}
