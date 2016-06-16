 /*  作者：      huwenhui
 *  创建时间：   2015/7/17 21:09:22
 *
 */
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
using TZHSWEET.ViewModel;
namespace TZHSWEET.BLL
{
    /// <summary>
    /// 服务层
    /// </summary>
    public class CategoryService : BaseService<PM_Category>, ICategoryService
    { 
         /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private ICategoryDao<PM_Category> myDao = null;

        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public CategoryService()
        {
			//spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();

            myDao = ctx.GetObject("CategoryDao") as ICategoryDao<PM_Category>;
            // DaoFactory.GetModuleDao();
            Dao = myDao;
        }

        #region 请求项目分类树
        /// <summary>
        /// 请求项目分类树
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IEnumerable<LigerUITree> GetCategoryTree(LigerUITreeRequest request)
        {
            //wher语句查询条件
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

            //返回ui层的菜单
            IEnumerable<LigerUITree> rootCategory = new List<LigerUITree>(){
            new LigerUITree()
            {

                icon = request.RootIcon,
                id=0,
                 desc="项目分类",
                text = "项目分类",
                children = (List<LigerUITree>)LigerUITree.ToListViewModel(myDao.GetEntities(commandText)),

            }
        };
            return rootCategory;

        }
        
        /// <summary>
        /// 获取类型下拉框选择数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LigerUISelect> GetAllCategorySelect()
        {
            string commandText = "";
            List<LigerUISelect> catelist = new List<LigerUISelect>();
            IEnumerable<PM_Category> clist=myDao.GetEntities(commandText);
            LigerUISelect selectitem = null;

            foreach (var item in clist)
            {
                selectitem=new LigerUISelect();
                selectitem.id = item.CategoryID;
                selectitem.text = item.CategoryName;
                catelist.Add(selectitem);
            }
            
            return catelist;
        }
        #endregion
    }
}
