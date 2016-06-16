/*  作者：      huwenhui
*  创建时间：   2016/2/16 15:43:02
*
*/
using System.Web.Mvc;
using TZHSWEET.UI;
using TZHSWEET.IBLL;
using TZHSWEET.BLL;
using TZHSWEET.ViewModel;
using TZHSWEET.Common;
using System.ComponentModel;
using TZHSWEET.Entity;
using System;

namespace TZHSWEET.WebUI.Areas.PM.Controllers
{
    
    [Description("审批管理")]
    public class ApproveController : BaseController
    {
        
        #region MVC页面视图导航

        [DefaultPage]
        [ViewPage]
        [Description("[Index首页]审批管理首页")]
        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region 获取任务数据

        //获取项目列表数据
        [Description("[审批管理]获取审批项目列表信息(主页必须)")]
        [LoginAllowView]
        public ActionResult GetProjectForGrid()
        {
            LigerUIGridRequest requestGrid = new LigerUIGridRequest(HttpContext);
            IApproveService approveService = new ApproveService();
            LigerUIGrid jsons = approveService.GetAllApproves(requestGrid);
            return this.JsonFormat(approveService.GetAllApproves(requestGrid));
        }

        #endregion

        #region 增删改查操作
        [Description("[审批管理]添加审批记录")]
        [LigerUIExceptionResult]
        public ActionResult Add()
        {
            ViewModelApprove approve = new ViewModelApprove(HttpContext, 1);
            IApproveService approveService = new ApproveService();
            bool status = approveService.Insert(ViewModelApprove.ToEntity(approve));
            UserOperateLog.WriteOperateLog("[添加项目]" + SysOperate.Add.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Add);
        }

        //更新项目信息
        [Description("[Index页面Update请求]更新审批信息")]
        [LigerUIExceptionResult]
        public ActionResult Update()
        {
            SysCurrentUser user = new SysCurrentUser();
            //获取请求信息
            ViewModelApprove approve = new ViewModelApprove(HttpContext, 1);
            IApproveService approveService = new ApproveService();
            var data = approveService.Update(ViewModelApprove.ToEntity(approve));
            UserOperateLog.WriteOperateLog("[项目审批信息]" + SysOperate.Update.ToMessage(data.IsNullOrEmpty()));
            return this.JsonFormat(data, SysOperate.Update);
        }

        //真删除
        [Description("[Index页面Delete请求]永久删除审批信息")]
        [LigerUIExceptionResult]
        public ActionResult RealDelete()
        {
            //获取请求信息
            ViewModelApprove approve = new ViewModelApprove(HttpContext,1);
            IApproveService approveService = new ApproveService();
            var status = approveService.Delete(approve.ID);
            UserOperateLog.WriteOperateLog("[项目审批信息]永久删除" + SysOperate.Delete.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Delete);
        }
       
        #endregion
    }
}
