using System.Collections.Generic;
using TZHSWEET.IBLL;
using TZHSWEET.Entity;
using TZHSWEET.IDao;
using TZHSWEET.Common;
using Spring.Context;
using Spring.Context.Support;
using TZHSWEET.ViewModel;
namespace TZHSWEET.BLL
{
    /// <summary>
    /// 服务层
    /// </summary>
    public class StaffService : BaseService<PM_Staff>, IStaffService
    {
        #region 依赖注入
        /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private IStaffDao<PM_Staff> myDao = null;

        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public StaffService()
        {
            //spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();

            myDao = ctx.GetObject("StaffDao") as IStaffDao<PM_Staff>;
            Dao = myDao;
        }

        
        #endregion

        #region 获取员工数据

       

        /// <summary>
        /// 获取所有任务数据（返回总数）
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        public IEnumerable<PM_Staff> GetAllStaffs(LigerUIGridRequest request, out int Count)
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
            return myDao.GetEntitiesForPaging("PM_Staff", request.PageNumber, request.PageSize, request.SortName, request.SortOrder, commandText, out Count);
        }

        /// <summary>
        /// 获取所有任务数据（列表）
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        public LigerUIGrid GetAllStaffs(LigerUIGridRequest request)
        {
            int total = 0;
            return new LigerUIGrid()
            {
                Rows = ViewModelStaff.ToListViewModel(GetAllStaffs(request, out total)),
                Total = total
            };
        }
        #endregion

        #region 增删改操作

        #endregion
    }
}
