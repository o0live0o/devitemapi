using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface IBaseService<T> where T : class
    {
        T Get(Expression<Func<T, bool>> @where);
    }
}
