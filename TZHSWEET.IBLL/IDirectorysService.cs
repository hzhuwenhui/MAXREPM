
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IDirectorysService : IBaseService<PM_Directorys>
    {
        /// <summary>
        /// 根据条件获取所有附件
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Directorys> GetAllDirectorys(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有附件
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllDirectorys(LigerUIGridRequest request);

    }
}
