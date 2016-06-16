using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TZHSWEET.BLL;
using TZHSWEET.Common;
using TZHSWEET.Entity;
using TZHSWEET.IBLL;
using TZHSWEET.UI;
using TZHSWEET.ViewModel;

namespace TZHSWEET.WebUI.Areas.PM.Controllers
{
    public class StaffController:BaseController
    {
        /// <summary>
        /// 根据条件获取员工列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //获取项目列表数据
        [Description("[员工管理]获取员工列表信息(主页必须)")]
        [LoginAllowView]
        public ActionResult Get()
        {
            LigerUIGridRequest requestGrid = new LigerUIGridRequest(HttpContext);
            IStaffService staffservice = new StaffService();
            return this.JsonFormat(staffservice.GetAllStaffs(requestGrid));
        }

        [Description("[selectStaff主页]显示所有的员工(Add,Update必须)")]
        [ViewPage]
        [LoginAllowView]
        public ActionResult SelectStaff()
        {
            return View();
        }
    }
}