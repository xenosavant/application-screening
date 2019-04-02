using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationScreening.Domain.Interfaces
{
    public interface IFilter<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}
