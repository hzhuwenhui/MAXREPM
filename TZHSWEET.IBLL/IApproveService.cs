
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IApproveService : IBaseService<PM_Approve>
    {
        /// <summary>
        /// 根据条件获取所有项目审批数据
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Approve> GetAllApproves(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有项目审批数据
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllApproves(LigerUIGridRequest request);

        /// <summary>
        /// 获取审批实体信息
        /// </summary>
        /// <param name="ID">项目ID</param>
        /// <returns></returns>
        PM_Approve GetApproveInfo(int ID);

        /// <summary>
        /// 审批项目
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        bool ApproveProject(int ProjectID);

        /// <summary>
        /// 审批项目
        /// </summary>
        /// <param name="TaskID">项目ID</param>
        /// <returns></returns>
        bool ApproveTask(int TaskID);
    }
}
