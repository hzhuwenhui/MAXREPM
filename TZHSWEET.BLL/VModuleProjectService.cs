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
    public class VModuleProjectService : BaseService<VModuleProject>, IVModuleProjectService
    {
        #region 依赖注入
        /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private IVModuleProjectDao<VModuleProject> myDao = null;
        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public VModuleProjectService()
        {
            //spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();

            myDao = ctx.GetObject("VModuleProjectDao") as IVModuleProjectDao<VModuleProject>;
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
                Rows = ViewModelProject.ToListViewModel2(GetAllProjects(request, out total)),
                Total = total
            };
        }

        /// <summary>
        /// 根据条件获取所有项目（多表联合查询）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public LigerUIGrid GetAllProjectsByView(LigerUIGridRequest request)
        {
            int total = 0;
            return new LigerUIGrid()
            {
                Rows = ViewModelProject.ToListViewModel2(GetAllProjectsByView(request, out total)),
                Total = total
            };
        }


        /// <summary>
        /// 根据条件获取所有项目
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        public IEnumerable<VModuleProject> GetAllProjects(LigerUIGridRequest request, out int Count)
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
            return myDao.GetEntitiesForPaging("VModuleProject", request.PageNumber, request.PageSize, request.SortName, request.SortOrder, commandText, out Count);
        }

        /// <summary>
        /// 根据条件获取所有项目（多表联合查询）
        /// </summary>
        /// <param name="request"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public IEnumerable<VModuleProject> GetAllProjectsByView(LigerUIGridRequest request, out int Count)
        {
            //返回查询结果
            return myDao.GetViewForPaging(request.PageNumber, request.PageSize, out Count);
        }

        #endregion

       
       
    }
}
