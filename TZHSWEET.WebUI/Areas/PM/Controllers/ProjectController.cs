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
    
    [Description("项目管理")]
    public class ProjectController : BaseController
    {
        
        #region MVC页面视图导航

        [DefaultPage]
        [ViewPage]
        [Description("[Index首页]项目管理首页")]
        public ActionResult Index()
        {
            return View();
        }

        [LoginAllowView]
        [Description("[新增页面]新增项目(按钮)")]
        public ActionResult New()
        {
            ViewDetailPage page = new ViewDetailPage(HttpContext);
            //ViewBag.IsView = page.IsView;
            ViewBag.ProjectCode=ProjectHelper.GetNewCode();
            ViewBag.CurrentID = page.CurrentID;
            UserOperateLog.WriteOperateLog("[新增项目详细信息]" + SysOperate.Load.ToMessage(true));
            return View();
        }

        //查看项目
        [Description("[Detail主页]浏览项目详细信息")]
        [ViewPage]
        public ActionResult Detail()
        {
            ViewDetailPage page = new ViewDetailPage(HttpContext);
            ViewBag.IsView = page.IsView;
            ViewBag.CurrentID = page.CurrentID;
            UserOperateLog.WriteOperateLog("[浏览项目详细信息]" + SysOperate.Load.ToMessage(true));
            return View();
        }

        //修改项目
        [Description("[Detail主页]浏览项目详细信息")]
        [ViewPage]
        public ActionResult Edit()
        {
            ViewDetailPage page = new ViewDetailPage(HttpContext);
            ViewBag.IsView = page.IsView;
            ViewBag.CurrentID = page.CurrentID;
            UserOperateLog.WriteOperateLog("[修改项目详细信息]" + SysOperate.Load.ToMessage(true));
            return View();
        }
        #endregion

        #region 获取项目数据

        //获取项目列表数据
        [Description("[项目管理]获取项目列表信息(主页必须)")]
        [LoginAllowView]
        public ActionResult GetProjectForGrid()
        {
            LigerUIGridRequest requestGrid = new LigerUIGridRequest(HttpContext);
            IProjectService projectService = new ProjectService();
            IVModuleProjectService vmpservice =new VModuleProjectService();
            //return this.JsonFormat(projectService.GetAllProjects(requestGrid));
            return this.JsonFormat(vmpservice.GetAllProjects(requestGrid));
        }

        //获取当前项目详细信息
        [Description("[Detail页面加载表单请求]获取一条项目信息(Detail,Update必须)")]
        [LigerUIExceptionResult]
        [LoginAllowView]
        public ActionResult Get(int ID)
        {
            //获取请求信息
            //ViewDetailPage request = new ViewDetailPage(HttpContext);

            IProjectService projectService = new ProjectService();
            //执行状态
            PM_Project project = projectService.GetEntity(p => p.ID == ID);
            
            //转化为视图UI层的实体对象
            var data = ViewModelProject.ToViewModel(project);

            //获取负责人名称
            StaffService staffservice = new StaffService();
            PM_Staff staff = staffservice.GetEntity(s => s.ID == project.leader_id);
            data.LeaderName = staff.FullName;

            UserOperateLog.WriteOperateLog("获取[项目信息]" + SysOperate.Operate.ToMessage(data.IsNullOrEmpty()));
            return this.JsonFormat(data, SysOperate.Operate);
        }

        [Description("[Index页面获得Tree一级树请求]获得一级菜单树(首页必须)")]
        [LoginAllowView]
        public ActionResult GetParentMenuTree()
        {
            //构造分页参数
            LigerUITreeRequest request = new LigerUITreeRequest(HttpContext);
            IUserService userService = new UserService();

            return this.JsonFormat(
                userService.GetUserTreeMenus(request, new SysCurrentUser().UserRoles)
                );

        }
        [Description("角色树形选择")]
        [LoginAllowView]
        public ActionResult GetCategorysForTree()
        {
            LigerUITreeRequest requestTree = new LigerUITreeRequest(HttpContext);
            ICategoryService categoryService = new CategoryService();
            return this.JsonFormat(categoryService.GetCategoryTree(requestTree));
        }
        #endregion

        #region 增删改查操作
        [Description("[项目新增信息]添加项目（动作）")]
        [LigerUIExceptionResult]
        public ActionResult Add()
        {
            ViewModelProject project = new ViewModelProject(HttpContext, true);
            IProjectService projectService = new ProjectService();
            bool status = projectService.Insert(ViewModelProject.ToEntity(project));
            UserOperateLog.WriteOperateLog("[添加项目]" + SysOperate.Add.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Add);
        }

        //更新项目信息
        [Description("[Index页面Update请求]更新项目")]
        [LigerUIExceptionResult]
        public ActionResult Update()
        {
            SysCurrentUser user = new SysCurrentUser();
            //获取请求信息
            ViewModelProject project = new ViewModelProject(HttpContext, false);
            IProjectService projectService = new ProjectService();
            var data = projectService.Update(ViewModelProject.ToEntity(project));
            UserOperateLog.WriteOperateLog("[项目信息]" + SysOperate.Update.ToMessage(data.IsNullOrEmpty()));
            return this.JsonFormat(data, SysOperate.Update);
        }

        //假删除
        [Description("[Index页面Delete请求]删除(假删)项目")]
        [LigerUIExceptionResult]
        public ActionResult Delete()
        {
            //获取请求信息
            ViewDetailPage page = new ViewDetailPage(HttpContext);
            IProjectService projectService = new ProjectService();
            var data = projectService.GetEntity(p => p.ID == Convert.ToInt32(page.CurrentID));
            data.IsDeleted = true;
            data.DeletedDate = DateTime.Now;
            bool status = projectService.Update(data);
            UserOperateLog.WriteOperateLog("[项目信息]删除(假删)项目:" + SysOperate.Delete.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Delete);
        }

        //真删除
        [Description("[Index页面Delete请求]永久删除项目")]
        [LigerUIExceptionResult]
        public ActionResult RealDelete()
        {
            //获取请求信息
            ViewModelProject project = new ViewModelProject(HttpContext, false);
            IProjectService projectService = new ProjectService();
            var status = projectService.Delete(project.ID);
            UserOperateLog.WriteOperateLog("[项目信息]永久删除" + SysOperate.Delete.ToMessage(status));
            return this.JsonFormat(status, status, SysOperate.Delete);
        }

        [Description("[页面加载表单请求]获取一条项目类型下拉框数据")]
        [LigerUIExceptionResult]
        [LoginAllowView]
        public ActionResult GetAllCategorySelect()
        {
            ICategoryService categoryservice = new CategoryService();

            var data = categoryservice.GetAllCategorySelect();
            return this.JsonFormat(data);
        }

        [Description("[页面加载表单请求]获取一条项目类型下拉框数据")]
        [LigerUIExceptionResult]
        [LoginAllowView]
        public ActionResult GetProjectTypeSelect()
        {
            IDictionaryService dicservice = new DictionaryService();

            var data = dicservice.GetProjectTypeForSelect(1);
            return this.JsonFormat(data);
        }


        #endregion
    }
}
