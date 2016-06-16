
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface ICategoryService : IBaseService<PM_Category>
    {
      /// <summary>
        /// 根据条件获取所有项目类型树
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
       IEnumerable<LigerUITree> GetCategoryTree(LigerUITreeRequest request);

        IEnumerable<LigerUISelect> GetAllCategorySelect();
    }
}
