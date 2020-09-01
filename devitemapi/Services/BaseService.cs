using devitemapi.Entity;
using devitemapi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class BaseService<T>// : IBaseService<T> where T : class
    {
        private readonly DevDbContext _context;

        public BaseService(DevDbContext devDbContext)
        {
            this._context = devDbContext;
        }

        public virtual T Get(Expression<Func<T, bool>> @where)
        {
            return default(T); // _context.Set<T>().FirstOrDefault(@where);
        }
    }
}
