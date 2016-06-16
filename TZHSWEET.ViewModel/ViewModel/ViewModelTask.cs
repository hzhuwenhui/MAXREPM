/*  作者：       huwenhui
*  创建时间：   2015/12/30 13:58:56
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
    public class ViewModelTask : ViewModelBase
    {
        #region - 属性 -

        public int ID { get; set; }
        public int? ProjectID { get; set; }
        public int? LeaderUserID { get; set; }
        public string TaskProfile { get; set; }
        public int? TaskState { get; set; }
        public DateTime? TaskStartDate { get; set; }
        public DateTime? TaskEndDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedUserID { get; set; }
        public bool? IsTimeOut { get; set; }
        public int? TaskLevel { get; set; }
        public int? TaskDuration { get; set; }//任务工期（天，不足一天按一天算）
        public DateTime? TaskCompleteDate { get; set; }//实际完成日期
        public double? TaskProgress { get; set; }//任务进度
        public int? ParentID { get; set; }
        //新增属性
        public string LeaderUserName { get; set; }
        public string TaskName { get; set; }
        #endregion

        #region - 构造函数 -

        public ViewModelTask()
        {
        }

        public ViewModelTask(HttpContextBase context, bool IsAdd)
        {
            if (!IsAdd)
            {
                ID = context.Request["ID"].ObjToInt();
                ModifyDate = DateTime.Now;
                ModifyUserID = SessionHelper.Get("UserID").ObjToIntNull();
            }
            else
            {
                CreateDate = DateTime.Now;
                CreateUserID = SessionHelper.Get("UserID").ObjToIntNull();
            }

            ProjectID = context.Request["ProjectID"].ObjToIntNull();
            LeaderUserID = context.Request["LeaderUserID"].ObjToIntNull();
            TaskProfile = context.Request["TaskProfile"];
            TaskState = context.Request["TaskState"].ObjToIntNull();
            TaskStartDate = context.Request["TaskStartDate"].ObjToDateNull();
            TaskEndDate = context.Request["TaskEndDate"].ObjToDateNull();
            IsTimeOut = context.Request["IsTimeOut"].ObjToBool();
            TaskLevel = context.Request["TaskLevel"].ObjToIntNull();
            TaskDuration = context.Request["TaskDuration"].ObjToIntNull();
            TaskProgress = context.Request["TaskProgress"].ObjToLong();
            TaskName= context.Request["TaskProfile"];
        }

        #endregion

        #region - 方法 -
        public static PM_Task ToEntity(ViewModelTask task)
        {
            PM_Task item = new PM_Task();
            item.ID = task.ID;
            item.TaskName = task.TaskName;
            item.ProjectID = task.ProjectID;
            item.LeaderUserID = task.LeaderUserID;
            item.TaskProfile = task.TaskProfile;
            item.TaskState = task.TaskState;
            item.TaskStartDate = task.TaskStartDate;
            item.TaskEndDate = task.TaskEndDate;
            item.IsTimeOut = task.IsTimeOut;
            item.CreateDate = task.CreateDate;
            item.CreateUserID = task.CreateUserID;
            item.ModifyDate = task.ModifyDate;
            item.ModifyUserID = task.ModifyUserID;
            item.TaskLevel = task.TaskLevel;
            item.TaskDuration = task.TaskDuration;
            item.TaskCompleteDate = task.TaskCompleteDate;
            item.TaskProgress = task.TaskProgress;
            return item;
        }

        public static ViewModelTask ToViewModel(PM_Task item)
        {
            ViewModelTask task = new ViewModelTask();
            task.ID = item.ID;
            task.ProjectID = item.ProjectID;
            task.LeaderUserID = item.LeaderUserID;
            task.TaskProfile = item.TaskProfile;
            task.TaskState = item.TaskState;
            task.TaskStartDate = item.TaskStartDate;
            task.TaskEndDate = item.TaskEndDate;
            task.IsTimeOut = item.IsTimeOut;
            task.TaskLevel = item.TaskLevel;
            task.TaskDuration = item.TaskDuration;
            task.TaskCompleteDate = item.TaskCompleteDate;
            task.TaskProgress = item.TaskProgress;
            task.TaskName = item.TaskName;
            return task;
        }

        public static IEnumerable<ViewModelTask> ToListViewModel(IEnumerable<PM_Task> tasks)
        {
            List<ViewModelTask> listModel = new List<ViewModelTask>();
            foreach (PM_Task task in tasks)
            {
                listModel.Add(ToViewModel(task));
            }
            return listModel;
        }

        /// <summary>
        /// 视图专用
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static ViewModelTask VToViewModel(ViewTask item)
        {
            ViewModelTask task = new ViewModelTask();
            task.ID = item.ID;
            task.ProjectID = item.ProjectID;
            task.LeaderUserID = item.LeaderUserID;
            task.TaskProfile = item.TaskProfile;
            task.TaskState = item.TaskState;
            task.TaskStartDate = item.TaskStartDate;
            task.TaskEndDate = item.TaskEndDate;
            task.IsTimeOut = item.IsTimeOut;
            task.TaskLevel = item.TaskLevel;
            task.TaskDuration = item.TaskDuration;
            task.TaskCompleteDate = item.TaskCompleteDate;
            task.TaskProgress = item.TaskProgress;
            task.LeaderUserName = item.FullName;
            task.TaskName = item.TaskName;

            return task;
        }

        /// <summary>
        /// 视图专用
        /// </summary>
        /// <param name="tasks"></param>
        /// <returns></returns>
        public static IEnumerable<ViewModelTask> VToListViewModel(IEnumerable<ViewTask> tasks)
        {
            List<ViewModelTask> listModel = new List<ViewModelTask>();
            foreach (ViewTask task in tasks)
            {
                listModel.Add(VToViewModel(task));
            }
            return listModel;
        }
        #endregion

    }
}
