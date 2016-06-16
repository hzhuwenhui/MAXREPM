
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TZHSWEET.IDao
{
    public interface ICustomerDao<T> : IBaseDao<T> where T : class
    {

    }
}
