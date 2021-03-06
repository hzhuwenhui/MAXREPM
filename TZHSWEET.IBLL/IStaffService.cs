﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IStaffService : IBaseService<PM_Staff>
    {
        /// <summary>
        /// 根据条件获取所有员工
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Staff> GetAllStaffs(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有员工
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllStaffs(LigerUIGridRequest request);
        
    }
}
