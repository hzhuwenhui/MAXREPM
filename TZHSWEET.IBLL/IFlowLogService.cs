
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IFlowLogService : IBaseService<PM_FlowLog>
    {
        /// <summary>
        /// 根据条件获取所有任务
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_FlowLog> GetAllFlowLogs(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllFlowLogs(LigerUIGridRequest request);

        /// <summary>
        /// 获取任务实体信息
        /// </summary>
        /// <param name="FlowID">任务ID</param>
        /// <returns></returns>
        PM_FlowLog GetFlowLogInfo(int FlowID);
        
    }
}
