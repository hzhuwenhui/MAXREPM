
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IDictionaryService : IBaseService<tbDictionary>
    {
        /// <summary>
        /// 根据条件获取所有字典数据的集合
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<tbDictionary> GetAllDictionarys(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有字典数据的集合
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllDictionarys(LigerUIGridRequest request);

        /// <summary>
        /// 根据条件获取所有符合条件的字典的集合
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IEnumerable<LigerUISelect> GetProjectTypeForSelect(LigerUISelectRequest request);

        IEnumerable<LigerUISelect> GetProjectTypeForSelect(int pid);
    }
}
