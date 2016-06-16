
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IVModuleProjectService : IBaseService<VModuleProject>
    {
        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<VModuleProject> GetAllProjects(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllProjects(LigerUIGridRequest request);

        /// <summary>
        /// 根据条件获取所有项目（多表联合查询结果）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        LigerUIGrid GetAllProjectsByView(LigerUIGridRequest request);

       
    }
}
