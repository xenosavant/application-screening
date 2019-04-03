using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationScreening.Domain.Entities.Common
{
    public abstract class ValueObject<T> : IEquatable<T>
    {
        public abstract int GetHashCode(T other);
        public abstract bool Equals(T other);

    }
}
