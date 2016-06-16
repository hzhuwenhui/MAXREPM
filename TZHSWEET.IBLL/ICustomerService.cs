
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface ICustomerService : IBaseService<PM_Customer>
    {
        /// <summary>
        /// 根据条件获取所有员工
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Customer> GetAllCustomers(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有员工
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllCustomers(LigerUIGridRequest request);
        
    }
}
