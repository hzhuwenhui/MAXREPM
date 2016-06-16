/******************************************************************************
 *  作者：       tianzh
 *  创建时间：   2012/6/6 22:24:27
 *
 *
 ******************************************************************************/
using System;
using System.Web;
using System.Drawing;
using System.Security.Cryptography;

namespace TZHSWEET.Common
{
    /// <summary>
    /// 项目公共类
    /// </summary>
    public static class ProjectHelper
    {
        #region 属性
        /// <summary>
        /// 项目编号
        /// </summary>
        public static string CODE { get; set; }

        #endregion

        #region 构造函数
        public static string GetNewCode()
        {
            CODE = DateTime.Now.ToString("yyyyMMddHHmmss");
            return CODE;
        }
        #endregion

    }
}