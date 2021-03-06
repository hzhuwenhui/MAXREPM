﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IPMDepartmentService : IBaseService<PM_Department>
    {
        /// <summary>
        /// 根据条件获取所有参与部门数据
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Department> GetAllDepartments(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有参与部门信息
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllDepartments(LigerUIGridRequest request);
        
    }
}
