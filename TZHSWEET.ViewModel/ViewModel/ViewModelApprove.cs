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
    public class ViewModelApprove : ViewModelBase
    {
        #region - 属性 -

        public int ID { get; set; }
        public int? ProjectID { get; set; }
        public int? ApproveUserID { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? ApproveState { get; set; }
        public string ApproveComments { get; set; }
        public int? ApproveType { get; set; }
        public int? ApplyUserID { get; set; }
        public DateTime? ApplyDate { get; set; }

        #endregion

        #region - 构造函数 -

        public ViewModelApprove()
        {
        }

        public ViewModelApprove(HttpContextBase context,int type)
        {
            ProjectID = context.Request["ProjectID"].ObjToIntNull();
            ApproveUserID = SessionHelper.Get("UserID").ObjToIntNull();//注意修改
            ApproveDate = DateTime.Now;//注意修改
            ApproveState = context.Request["ApproveState"].ObjToIntNull();
            ApproveComments = context.Request["ApproveComments"];
            ApproveType = type;
            ApplyUserID= SessionHelper.Get("UserID").ObjToIntNull();//注意修改
            ApplyDate = DateTime.Now;//注意修改
        }

        #endregion

        #region - 方法 -
        public static PM_Approve ToEntity(ViewModelApprove approve)
        {
            PM_Approve item = new PM_Approve();
            item.ID = approve.ID;
            item.ProjectID = approve.ProjectID;
            item.ApproveUserID = approve.ApproveUserID;
            item.ApproveDate = approve.ApproveDate;
            item.ApproveState = approve.ApproveState;
            item.ApproveComments = approve.ApproveComments;
            item.ApproveType = approve.ApproveType;

            return item;
        }

        public static ViewModelApprove ToViewModel(PM_Approve item)
        {
            ViewModelApprove approve = new ViewModelApprove();
            approve.ID= item.ID;
            approve.ProjectID = item.ProjectID;
            approve.ApproveUserID = item.ApproveUserID;
            approve.ApproveDate = item.ApproveDate;
            approve.ApproveState = item.ApproveState;
            approve.ApproveComments = item.ApproveComments;
            approve.ApproveType = item.ApproveType;

            return approve;
        }

        public static IEnumerable<ViewModelApprove> ToListViewModel(IEnumerable<PM_Approve> approves)
        {
            List<ViewModelApprove> listModel = new List<ViewModelApprove>();
            foreach (PM_Approve approve in approves)
            {
                listModel.Add(ToViewModel(approve));
            }
            return listModel;
        }

        #endregion

    }
}
