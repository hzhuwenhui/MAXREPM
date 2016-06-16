
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.ViewModel;

namespace TZHSWEET.IBLL
{
   public interface IContractService : IBaseService<PM_Contract>
    {
        /// <summary>
        /// 根据条件获取所有合同数据
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <param name="Count">记录总数</param>
        /// <returns></returns>
        IEnumerable<PM_Contract> GetAllContracts(LigerUIGridRequest request, out int Count);

        /// <summary>
        /// 根据条件获取所有合同数据
        /// </summary>
        /// <param name="request">请求条件</param>
        /// <returns></returns>
        LigerUIGrid GetAllContracts(LigerUIGridRequest request);

        /// <summary>
        /// 获取合同实体信息
        /// </summary>
        /// <param name="ContractID">合同ID</param>
        /// <returns></returns>
        PM_Contract GetContractInfo(int ContractID);
        
    }
}
