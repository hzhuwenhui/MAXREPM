/*  作者：      huwenhui
*  创建时间：   2012/7/30 23:58:56
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using TZHSWEET.Entity;
using TZHSWEET.Common;
namespace TZHSWEET.ViewModel
{
    public class ViewModelProject : ViewModelBase
    {
        #region - 属性 -

        public int ID { get; set; }

        public string ProjectCode { get; set; }

        public string ProjectName { get; set; }

        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }

        public int? ProjectLevel { get; set; }

        public string ProjectAddress { get; set; }

        public string ProjectProfile { get; set; }
        
        public int? LeaderID { get; set; }
        public string LeaderName { get; set; }

        public int? CustomerID { get; set; }
        public string CustomerName { get; set; }

        public int? ProjectStatus { get; set; }

        public double? TotalBudget { get; set; }

        public string PlancycleStartdate { get; set; }

        public string PlancycleEnddate { get; set; }

        public string DeliveryDate { get; set; }
        
        public bool? IsTimeOut { get; set; }

        public int? DeletedUserID { get; set; }

        public string DeletedDate { get; set; }

        public int? ChangeLastID { get; set; }

        public string ChangeLastTime { get; set; }


        #endregion

        #region - 构造函数 -

        public ViewModelProject()
        {
        }

        public ViewModelProject(HttpContextBase context, bool IsAdd)
        {
            if (!IsAdd)
            {
                ID = context.Request["ID"].ObjToInt();
                ModifyDate = DateTime.Now;
                ModifyUserID = SessionHelper.Get("ID").ObjToIntNull();
                if(IsDeleted)DeletedUserID= ModifyUserID;
            }
            else
            {
                CreateDate = DateTime.Now;
                CreateUserID = SessionHelper.Get("UserID").ObjToIntNull();
                IsDeleted =false;
            }

            ProjectCode = context.Request["ProjectCode"];
            ProjectName = context.Request["ProjectName"];
            CategoryID = context.Request["CategoryID"].ObjToIntNull();
            ProjectLevel = context.Request["ProjectLevel"].ObjToIntNull();
            ProjectAddress = context.Request["ProjectAddress"];
            ProjectProfile = context.Request["ProjectProfile"];
            LeaderID = context.Request["LeaderID"].ObjToIntNull();
            CustomerName = context.Request["CustomerName"];
            ProjectStatus = context.Request["ProjectStatus"].ObjToIntNull();
            TotalBudget = context.Request["TotalBudget"].ObjToLong();
            PlancycleStartdate = context.Request["PlancycleStartdate"];
            PlancycleEnddate = context.Request["PlancycleEnddate"];
            if (!context.Request["DeliveryDate"].IsNullOrEmpty()) {
                DeliveryDate = context.Request["DeliveryDate"];
            }

            IsTimeOut = context.Request["IsTimeOut"].ObjToBool();
            ChangeLastID = context.Request["ChangeLastID"].ObjToIntNull();
            if (!context.Request["ChangeLastTime"].IsNullOrEmpty())
            {
                ChangeLastTime = context.Request["ChangeLastTime"];
            }

        }

        #endregion

        #region - 方法 -
        public static PM_Project ToEntity(ViewModelProject project)
        {
            PM_Project item = new PM_Project();
            item.ID = project.ID;
            item.project_code = project.ProjectCode;
            item.project_name = project.ProjectName;
            item.category_id = project.CategoryID;
            item.project_level = project.ProjectLevel;
            item.project_profile = project.ProjectProfile;
            item.project_address = project.ProjectAddress;
            item.leader_id = project.LeaderID;
            item.customer_name = project.CustomerName;
            item.project_status = project.ProjectStatus;
            item.totalbudget= project.TotalBudget;
            item.change_lasttime = project.ChangeLastTime.ObjToDateNull();
            item.change_lastid = project.ChangeLastID;
            item.deliverydate = project.DeliveryDate.ObjToDateNull();
            item.IsTimeOut = project.IsTimeOut;
            item.plancycle_enddate = project.PlancycleEnddate.ObjToDateNull();
            item.plancycle_startdate = project.PlancycleStartdate.ObjToDateNull();
            item.IsDeleted = project.IsDeleted;

            return item;
        }

        public static ViewModelProject ToViewModel(PM_Project item)
        {
            ViewModelProject project = new ViewModelProject();
            project.ID= item.ID;
            project.ProjectCode = item.project_code;
            project.ProjectName = item.project_name;
            project.CategoryID = item.category_id;
            project.ProjectLevel =item.project_level;
            project.ProjectProfile = item.project_profile;
            project.ProjectAddress =item.project_address;
            project.LeaderID = item.leader_id;
            project.CustomerName = item.customer_name;
            project.ProjectStatus = item.project_status;
            project.TotalBudget = item.totalbudget;
            project.PlancycleEnddate = item.plancycle_enddate.ToString();
            project.PlancycleStartdate = item.plancycle_startdate.ToString();
            project.ChangeLastTime = item.change_lasttime.ToString();
            project.ChangeLastID = item.change_lastid;
            project.DeliveryDate = item.deliverydate.ToString();
            project.IsTimeOut = item.IsTimeOut;

            return project;
        }

     
        public static IEnumerable<ViewModelProject> ToListViewModel(IEnumerable<PM_Project> projects)
        {
            List<ViewModelProject> listModel = new List<ViewModelProject>();
            foreach (PM_Project project in projects)
            {
                listModel.Add(ToViewModel(project));
            }
            return listModel;
        }


        public static ViewModelProject ToViewModel2(VModuleProject item)
        {
            ViewModelProject project = new ViewModelProject();
            project.ID = item.ID;
            project.ProjectCode = item.project_code;
            project.ProjectName = item.project_name;
            project.CategoryID = item.category_id;
            project.CategoryName = item.category_name;
            project.ProjectLevel = item.project_level;
            project.ProjectProfile = item.project_profile;
            project.ProjectAddress = item.project_address;
            project.LeaderID = item.leader_id;
            project.LeaderName = item.leader_name;
            project.CustomerName = item.customer_name;
            project.ProjectStatus = item.project_status;
            project.TotalBudget = item.totalbudget;
            project.PlancycleEnddate = item.plancycle_enddate.ToString();
            project.PlancycleStartdate = item.plancycle_startdate.ToString();
            project.DeliveryDate = item.deliverydate.ToString();
            project.IsTimeOut = item.IsTimeOut;

            return project;
        }

        public static ViewModelProject ToViewModel3(PM_Project item, PM_Staff staff, PM_Category category)
        {
            ViewModelProject project = new ViewModelProject();
            project.ID = item.ID;
            project.ProjectCode = item.project_code;
            project.ProjectName = item.project_name;
            project.CategoryID = item.category_id;
            project.CategoryName = category.CategoryName;
            project.ProjectLevel = item.project_level;
            project.ProjectProfile = item.project_profile;
            project.ProjectAddress = item.project_address;
            project.LeaderID = item.leader_id;
            project.LeaderName = staff.FullName;
            project.CustomerName = item.customer_name;
            project.ProjectStatus = item.project_status;
            project.TotalBudget = item.totalbudget;
            project.PlancycleEnddate = item.plancycle_enddate.ToString();
            project.PlancycleStartdate = item.plancycle_startdate.ToString();
            project.ChangeLastTime = item.change_lasttime.ToString();
            project.ChangeLastID = item.change_lastid;
            project.DeliveryDate = item.deliverydate.ToString();
            project.IsTimeOut = item.IsTimeOut;

            return project;
        }

        public static IEnumerable<ViewModelProject> ToListViewModel2(IEnumerable<VModuleProject> projects)
        {
            List<ViewModelProject> listModel = new List<ViewModelProject>();
            foreach (VModuleProject project in projects)
            {
                listModel.Add(ToViewModel2(project));
            }
            return listModel;
        }
        #endregion

    }
}
