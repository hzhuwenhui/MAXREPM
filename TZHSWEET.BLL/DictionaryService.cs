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
    public class DictionaryService : BaseService<tbDictionary>, IDictionaryService
    { 
         /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private IDictionaryDao<tbDictionary> myDao = null;

        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public DictionaryService()
        {
			//spring.net注入
            IApplicationContext ctx = ContextRegistry.GetContext();
      
            myDao = ctx.GetObject("DictionaryDao") as IDictionaryDao<tbDictionary>;
            Dao = myDao;
        }

        public LigerUIGrid GetAllDictionarys(LigerUIGridRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbDictionary> GetAllDictionarys(LigerUIGridRequest request, out int Count)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<LigerUISelect> GetProjectTypeForSelect(LigerUISelectRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LigerUISelect> GetProjectTypeForSelect(int pid)
        {
            string commandText = "";
            if (pid!=0)
            {
                ////做Where的翻译处理工作
                //FilterTranslator whereTranslator = new FilterTranslator();
                ////反序列化Filter Group JSON
                //whereTranslator.Group = JsonHelper.FromJson<FilterGroup>(pid.ToString());
                ////开始翻译sql语句
                //whereTranslator.Translate();
                //commandText = FilterParam.AddParameters(whereTranslator.CommandText, whereTranslator.Parms);
                commandText = "ParentID="+pid;
            }

            List<LigerUISelect> catelist = new List<LigerUISelect>();
            IEnumerable<tbDictionary> clist = myDao.GetEntities(commandText);
            LigerUISelect selectitem = null;

            foreach (var item in clist)
            {
                selectitem = new LigerUISelect();
                selectitem.id = item.DicID;
                selectitem.text = item.DicName;
                catelist.Add(selectitem);
            }

            return catelist;
        }
    }
}
