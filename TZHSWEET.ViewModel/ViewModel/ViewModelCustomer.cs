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
    public class ViewModelCustomer : ViewModelBase
    {
        #region - 属性 -

        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string ContactMan { get; set; }
        public string ContactPhone { get; set; }
        

        #endregion

        #region - 构造函数 -

        public ViewModelCustomer()
        {
        }

        public ViewModelCustomer(HttpContextBase context, bool IsAdd)
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

            CustomerName = context.Request["CustomerName"];
            ContactMan = context.Request["ContactMan"];
            ContactPhone = context.Request["ContactPhone"];
            
        }

        #endregion

        #region - 方法 -
        public static PM_Customer ToEntity(ViewModelCustomer customer)
        {
            PM_Customer item = new PM_Customer();
            item.ID = customer.ID;
            item.CustomerName = customer.CustomerName;
            item.ContactMan = customer.ContactMan;
            item.ContactPhone = customer.ContactPhone;
            
            return item;
        }

        public static ViewModelCustomer ToViewModel(PM_Customer item)
        {
            ViewModelCustomer customer = new ViewModelCustomer();
            customer.ID = item.ID;
            customer.CustomerName = item.CustomerName;
            customer.ContactMan = item.ContactMan;
            customer.ContactPhone = item.ContactPhone;
            
            return customer;
        }

        public static IEnumerable<ViewModelCustomer> ToListViewModel(IEnumerable<PM_Customer> customers)
        {
            List<ViewModelCustomer> listModel = new List<ViewModelCustomer>();
            foreach (PM_Customer customer in customers)
            {
                listModel.Add(ToViewModel(customer));
            }
            return listModel;
        }

        #endregion

    }
}
