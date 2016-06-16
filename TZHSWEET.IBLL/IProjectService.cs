
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IProjectService : IBaseService<PM_Project>
    {
        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Project> GetAllProjects(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllProjects(LigerUIGridRequest request);

        /// <summary>
        /// 获取项目实体信息
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        ViewModelProject GetProjectInfo(int ProjectID);

        /// <summary>
        /// 项目变更
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        bool ChangeProject(PM_Project project);

        /// <summary>
        /// 发送立项审批请求
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        bool SendApproval(int ProjectID);

        /// <summary>
        /// 改变项目状态
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        bool ChangeStatus(int ProjectID);

        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        bool DeleteProject(int ProjectID);

        /// <summary>
        /// 设置超时状态
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        bool SetTimeOutFlag(int ProjectID);
    }
}
