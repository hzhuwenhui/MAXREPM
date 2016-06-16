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
    
    [Description("任务管理")]
    public class TaskController : BaseController
    {
        
        #region MVC页面视图导航

        [DefaultPage]
        [ViewPage]
        [Description("[Index首页]任务管理首页")]
        public ActionResult Index()
        {
            return View();
        }

        [LoginAllowView]
        [Description("[新增页面]新增任务(按钮)")]
        public ActionResult New()
        {
            ViewDetailPage page = new ViewDetailPage(HttpContext);
            //ViewBag.IsView = page.IsView;
            ViewBag.CurrentID = page.CurrentID;
            UserOperateLog.WriteOperateLog("[新增任务详细信息]" + SysOperate.Load.ToMessage(true));
            return View();
        }

        //查看任务信息
        [Description("[Detail主页]浏览任务详细信息")]
        [ViewPage]
        public ActionResult Detail()
        {
            ViewDetailPage page = new ViewDetailPage(HttpContext);
            ViewBag.IsView = page.IsView;
            ViewBag.CurrentID = page.CurrentID;
            UserOperateLog.WriteOperateLog("[浏览任务详细信息]" + SysOperate.Load.ToMessage(true));
            return View();
        }

        #endregion

        #region 获取任务数据

        //获取项目列表数据
        [Description("[任务管理]获取任务列表信息(主页必须)")]
        [LoginAllowView]
        public ActionResult GetTaskForGrid()
        {
            LigerUIGridRequest requestGrid = new LigerUIGridRequest(HttpContext);
            IViewTaskService VTaskService = new ViewTaskService();
            return this.JsonFormat(VTaskService.GetAllTasks(requestGrid));
        }

        //获取当前任务详细信息
        [Description("[Detail页面加载表单请求]获取一条任务信息(Detail,Update必须)")]
        [LigerUIExceptionResult]
        [LoginAllowView]
        public ActionResult Get(int ID)
        {
            //获取请求信息
            //ViewDetailPage request = new ViewDetailPage(HttpContext);

            ITaskService taskService = new TaskService();
            //执行状态
            PM_Task task = taskService.GetEntity(p => p.ID == ID);

            //转化为视图UI层的实体对象
            var data = ViewModelTask.ToViewModel(task);
            UserOperateLog.WriteOperateLog("获取[任务信息]" + SysOperate.Operate.ToMessage(data.IsNullOrEmpty()));
            return this.JsonFormat(data, SysOperate.Operate);
        }
        #endregion

        #region 增删改查操作
        [Description("[任务新增信息]添加任务（动作）")]
        [LigerUIExceptionResult]
        public ActionResult Add()
        {
            ViewModelTask task = new ViewModelTask(HttpContext, true);
            ITaskService taskService = new TaskService();
            bool status = taskService.Insert(ViewModelTask.ToEntity(task));
            UserOperateLog.WriteOperateLog("[添加任务]" + SysOperate.Add.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Add);
        }

        //更新任务信息
        [Description("[Index页面Update请求]更新任务")]
        [LigerUIExceptionResult]
        public ActionResult Update()
        {
            SysCurrentUser user = new SysCurrentUser();
            //获取请求信息
            ViewModelTask task = new ViewModelTask(HttpContext, false);
            ITaskService taskService = new TaskService();
            var data = taskService.Update(ViewModelTask.ToEntity(task));
            UserOperateLog.WriteOperateLog("[任务信息]" + SysOperate.Update.ToMessage(data.IsNullOrEmpty()));
            return this.JsonFormat(data, SysOperate.Update);
        }

        //假删除
        [Description("[Index页面Delete请求]删除(假删)任务")]
        [LigerUIExceptionResult]
        public ActionResult Delete()
        {
            //获取请求信息
            ViewModelTask task = new ViewModelTask(HttpContext, false);
            ITaskService taskService = new TaskService();
            var data = taskService.GetEntity(p => p.ID == Convert.ToInt32(task.ID));
            data.IsDeleted = true;
            bool status = taskService.Update(data);
            UserOperateLog.WriteOperateLog("[任务信息]删除(假删)任务:" + SysOperate.Delete.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Delete);
        }

        //真删除
        [Description("[Index页面Delete请求]永久删除任务")]
        [LigerUIExceptionResult]
        public ActionResult RealDelete()
        {
            //获取请求信息
            ViewModelTask task = new ViewModelTask(HttpContext, false);
            ITaskService taskService = new TaskService();
            var status = taskService.Delete(task.ID);
            UserOperateLog.WriteOperateLog("[任务信息]永久删除" + SysOperate.Delete.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Delete);
        }
       
        #endregion
    }
}
