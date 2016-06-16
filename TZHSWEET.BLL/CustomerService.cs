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
    public class CustomerService : BaseService<PM_Customer>, ICustomerService
    {
        #region 依赖注入
        /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private ICustomerDao<PM_Customer> myDao = null;

        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public CustomerService()
        {
            //spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();

            myDao = ctx.GetObject("CustomerDao") as ICustomerDao<PM_Customer>;
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
        public IEnumerable<PM_Customer> GetAllCustomers(LigerUIGridRequest request, out int Count)
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
            return myDao.GetEntitiesForPaging("PM_Customer", request.PageNumber, request.PageSize, request.SortName, request.SortOrder, commandText, out Count);
        }

        /// <summary>
        /// 获取所有任务数据（列表）
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        public LigerUIGrid GetAllCustomers(LigerUIGridRequest request)
        {
            int total = 0;
            return new LigerUIGrid()
            {
                Rows = ViewModelCustomer.ToListViewModel(GetAllCustomers(request, out total)),
                Total = total
            };
        }
        #endregion

        #region 增删改操作

        #endregion
    }
}
