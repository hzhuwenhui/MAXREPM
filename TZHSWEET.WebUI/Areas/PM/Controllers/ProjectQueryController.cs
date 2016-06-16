 /*  作者：      huwenhui
 *  创建时间：   2015/12/16 15:43:02
 *
 */
using System.Web.Mvc;
using TZHSWEET.UI;
using TZHSWEET.IBLL;
using TZHSWEET.BLL;
using TZHSWEET.ViewModel;
using TZHSWEET.Common;
using System.ComponentModel;

namespace TZHSWEET.WebUI.Areas.PM.Controllers
{
    
    [Description("项目查询")]
    public class ProjectQueryController : BaseController
    {
        [DefaultPage]
        [ViewPage]
        [Description("[Index首页]项目查询")]
        public ActionResult Index()
        {
            return View();
        }

        #region 获取用户列表数据
        [Description("[项目查询]获取项目列表信息(主页必须)")]
        [LoginAllowView]
        public ActionResult GetProjectForGrid()
        {
            LigerUIGridRequest requestGrid = new LigerUIGridRequest(HttpContext);
            IProjectService projectService = new ProjectService();
            return this.JsonFormat(projectService.GetAllProjects(requestGrid));
        }

        
        #endregion
    }
}
