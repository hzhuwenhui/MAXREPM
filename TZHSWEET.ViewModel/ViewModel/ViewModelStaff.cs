/*  作者：       huwenhui
*  创建时间：   2015/12/30 13:58:56
*
*/
using System;
using System.Collections.Generic;
using System.Web;
using TZHSWEET.Entity;
using TZHSWEET.Common;
namespace TZHSWEET.ViewModel
{
    public class ViewModelStaff : ViewModelBase
    {
        #region - 属性 -

        public int ID { get; set; }
        public int? DeptID { get; set; }
        public string FullName { get; set; }
        public int? Sex { get; set; }
        public int? Age { get; set; }
        public string PostName { get; set; }
        public int? DimissionState { get; set; }
        public string Phone { get; set; }
        #endregion

        #region - 构造函数 -

        public ViewModelStaff()
        {
        }

        public ViewModelStaff(HttpContextBase context, bool IsAdd)
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

            DeptID = context.Request["DeptID"].ObjToIntNull();
            FullName = context.Request["FullName"];
            Sex = context.Request["Sex"].ObjToIntNull();
            Age = context.Request["Age"].ObjToIntNull();
            PostName = context.Request["PostName"];
            DimissionState = context.Request["DimissionState"].ObjToIntNull();
            Phone = context.Request["Phone"];

        }

        #endregion

        #region - 方法 -
        public static PM_Staff ToEntity(ViewModelStaff staff)
        {
            PM_Staff item = new PM_Staff();
            item.ID = staff.ID;
            item.DeptID = staff.DeptID;
            item.FullName = staff.FullName;
            
            return item;
        }

        public static ViewModelStaff ToViewModel(PM_Staff item)
        {
            ViewModelStaff staff = new ViewModelStaff();
            staff.ID = item.ID;
            staff.DeptID = item.DeptID;
            staff.FullName = item.FullName;
            
            return staff;
        }

        public static IEnumerable<ViewModelStaff> ToListViewModel(IEnumerable<PM_Staff> staffs)
        {
            List<ViewModelStaff> listModel = new List<ViewModelStaff>();
            foreach (PM_Staff staff in staffs)
            {
                listModel.Add(ToViewModel(staff));
            }
            return listModel;
        }

        #endregion

    }
}
