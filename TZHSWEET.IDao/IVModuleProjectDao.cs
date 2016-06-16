
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;

namespace TZHSWEET.IDao
{
    public interface IVModuleProjectDao<T> : IBaseDao<T> where T : class
    {
        IEnumerable<T> GetViewForPaging(int pageNumber, int pageSize, out int Count);
    }
}
