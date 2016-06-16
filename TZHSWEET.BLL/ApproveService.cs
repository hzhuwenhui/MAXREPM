using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.IBLL;
using TZHSWEET.Entity;
using TZHSWEET.IDao;
using TZHSWEET.Common;
using Spring.Context;
using Spring.Context.Support;
using System.Data.Objects;
using TZHSWEET.ViewModel;
namespace TZHSWEET.BLL
{
    /// <summary>
    /// 服务层
    /// </summary>
    public class ApproveService : BaseService<PM_Approve>, IApproveService
    {
        #region 依赖注入
        /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private IApproveDao<PM_Approve> myDao = null;

        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public ApproveService()
        {
            //spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();

            myDao = ctx.GetObject("ApproveDao") as IApproveDao<PM_Approve>;
            Dao = myDao;
        }

        
        #endregion

        #region 获取项目数据

        #endregion

        /// <summary>
        /// 获取所有任务数据（返回总数）
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        public IEnumerable<PM_Approve> GetAllApproves(LigerUIGridRequest request, out int Count)
        {
            string commandText = "";
            if (!request.Where.IsNullOrEmpty())
            {
                //做Where的翻译处理工作
                FilterTranslator whereTranslator = new FilterTranslator();
                //反序列化Filter Group JSON
                whereTranslator.Group = JsonHelper.FromJson<FilterGroup>(request.Where);
                //开始翻译sql语句
                whereTranslator.Translate();
                commandText = FilterParam.AddParameters(whereTranslator.CommandText, whereTranslator.Parms);
            }
            return myDao.GetEntitiesForPaging("PM_Approve", request.PageNumber, request.PageSize, request.SortName, request.SortOrder, commandText, out Count);
        }

        /// <summary>
        /// 获取所有任务数据（列表）
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        public LigerUIGrid GetAllApproves(LigerUIGridRequest request)
        {
            int total = 0;
            return new LigerUIGrid()
            {
                Rows = ViewModelApprove.ToListViewModel(GetAllApproves(request, out total)),
                Total = total
            };
        }

        /// <summary>
        /// 获取任务实体信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public PM_Approve GetApproveInfo(int ID)
        {
            int Id = Convert.ToInt32(ID);
            return myDao.GetEntity(p => p.ID == Id);
        }

        /// <summary>
        /// 审核任务完成申请
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public bool ApproveTask(int TaskID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 审核任务完成申请
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        public bool ApproveProject(int ProjectID)
        {
            throw new NotImplementedException();
        }

        #region 增删改操作

        #endregion
    }
}
