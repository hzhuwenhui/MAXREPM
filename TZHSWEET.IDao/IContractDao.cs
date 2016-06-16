
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TZHSWEET.IDao
{
    public interface IContractDao<T> : IBaseDao<T> where T : class
    {

    }
}
