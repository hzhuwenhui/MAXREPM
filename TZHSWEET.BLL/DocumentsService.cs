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
    public class DocumentsService : BaseService<PM_Documents>, IDocumentsService
    { 
         /// <summary>
        /// 该接口负责用户自定义的功能实现
        /// </summary>
        private IDocumentsDao<PM_Documents> myDao = null;

        /// <summary>
        /// 构造函数(接口转换,Dao只负责基类的增删改查)
        /// </summary>
        public DocumentsService()
        {
			//spring.net注入
        IApplicationContext ctx = ContextRegistry.GetContext();
      
            myDao = ctx.GetObject("DocumentsDao") as IDocumentsDao<PM_Documents>;
            Dao = myDao;
        }

        public LigerUIGrid GetAllDocuments(LigerUIGridRequest request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PM_Documents> GetAllDocuments(LigerUIGridRequest request, out int Count)
        {
            throw new NotImplementedException();
        }

        public PM_Documents GetDocumentInfo(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
