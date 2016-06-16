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
    public class CustomerController:BaseController
    {
        /// <summary>
        /// 根据条件获取员工列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //获取项目列表数据
        [Description("[客户管理]获取所有客户(主页必须)")]
        [LoginAllowView]
        public ActionResult Get()
        {
            LigerUIGridRequest requestGrid = new LigerUIGridRequest(HttpContext);
            ICustomerService customerservice = new CustomerService();
            return this.JsonFormat(customerservice.GetAllCustomers(requestGrid));
        }

        [Description("[弹出框主页]显示所有的客户(Add,Update必须)")]
        [ViewPage]
        [LoginAllowView]
        public ActionResult SelectCustomer()
        {
            return View();
        }
    }
}