
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IProgressLogService : IBaseService<PM_ProgressLog>
    {
        /// <summary>
        /// 根据条件获取所有任务
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_ProgressLog> GetAllProgressLogs(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllProgressLogs(LigerUIGridRequest request);

        /// <summary>
        /// 获取任务实体信息
        /// </summary>
        /// <param name="ID">任务ID</param>
        /// <returns></returns>
        PM_ProgressLog GetProgressLogInfo(int ID);
        
    }
}
