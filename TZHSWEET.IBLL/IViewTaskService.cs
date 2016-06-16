
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IViewTaskService : IBaseService<ViewTask>
    {
        /// <summary>
        /// 根据条件获取所有任务
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<ViewTask> GetAllTasks(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllTasks(LigerUIGridRequest request);

        /// <summary>
        /// 获取任务实体信息
        /// </summary>
        /// <param name="TaskID">任务ID</param>
        /// <returns></returns>
        ViewTask GetTaskInfo(int TaskID);

        /// <summary>
        /// 改变任务状态
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        bool ChangeStatus(int TaskID);

        
    }
}
