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
    public class ProjectService : BaseService<PM_Project>, IProjectService
    {
        #region 依赖注入
        /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private IProjectDao<PM_Project> myDao = null;
        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public ProjectService()
        {
            //spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();

            myDao = ctx.GetObject("ProjectDao") as IProjectDao<PM_Project>;
            Dao = myDao;
            
        }
        
        #endregion

        #region 获取项目数据

        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        public LigerUIGrid GetAllProjects(LigerUIGridRequest request)
        {
            int total = 0;
            return new LigerUIGrid()
            {
                Rows = ViewModelProject.ToListViewModel(GetAllProjects(request, out total)),
                Total = total
            };
        }

        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        public IEnumerable<PM_Project> GetAllProjects(LigerUIGridRequest request, out int Count)
        {
            //throw new NotImplementedException();
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
            return myDao.GetEntitiesForPaging("PM_Project", request.PageNumber, request.PageSize, request.SortName, request.SortOrder, commandText, out Count);
        }

        /// <summary>
        /// 获取项目实体信息
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        public ViewModelProject GetProjectInfo(int ProjectID)
        {
            //throw new NotImplementedException();
            PM_Project project=GetEntity(p => p.ID == ProjectID);
            StaffService staffsv = new StaffService();
            PM_Staff staff = staffsv.GetEntity(s => s.ID == project.leader_id);
            CategoryService catesv = new CategoryService();
            PM_Category cate = catesv.GetEntity(c => c.CategoryID == project.category_id);
            return ViewModelProject.ToViewModel3(project, staff, cate);
        }

        #endregion

        #region 增删改操作

        /// <summary>
        /// 项目变更
        /// </summary>
        /// <param name="project">项目实体</param>
        /// <returns></returns>
        public bool ChangeProject(PM_Project project)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 改变项目状态
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        public bool ChangeStatus(int ProjectID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除项目（假删除）
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        public bool DeleteProject(int ProjectID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 项目送审
        /// </summary>
        /// <param name="ProjectID">项目ID</param>
        /// <returns></returns>
        public bool SendApproval(int ProjectID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 设定项目超时标识
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        public bool SetTimeOutFlag(int ProjectID)
        {
            throw new NotImplementedException();
        }

        #endregion

       
    }
}
