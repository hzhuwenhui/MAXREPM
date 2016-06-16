
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IDocumentsService : IBaseService<PM_Documents>
    {
        /// <summary>
        /// 根据条件获取所有附件
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Documents> GetAllDocuments(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有附件
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllDocuments(LigerUIGridRequest request);

        /// <summary>
        /// 获取附件实体信息
        /// </summary>
        /// <param name="ID">附件实体ID</param>
        /// <returns></returns>
        PM_Documents GetDocumentInfo(int ID);

    }
}
