using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TZHSWEET.Entity;
using TZHSWEET.IDao;

namespace TZHSWEET.EFDao
{
    public class VModuleProjectEFDao : BaseEFDao<VModuleProject>, IVModuleProjectDao<VModuleProject>
    {

       public IEnumerable<VModuleProject> GetViewForPaging(int pageNumber, int pageSize,out int Count)
        {
            List<VModuleProject> listproject =new List<VModuleProject>();
            using (BaseManageEntities Entities = new BaseManageEntities())
            {
                //查询所有的项目信息
                var table = from p in Entities.PM_Project
                            join s in Entities.PM_Staff on p.leader_id equals s.ID
                            join c in Entities.PM_Category on p.category_id equals c.CategoryID
                            where p.IsDeleted==false
                            select new
                            {
                                p.ID,
                                p.category_id,
                                c.CategoryName,
                                p.customer_name,
                                p.deliverydate,
                                p.IsTimeOut,
                                p.leader_id,
                                s.FullName,
                                p.plancycle_enddate,
                                p.plancycle_startdate,
                                p.project_address,
                                p.project_code,
                                p.project_level,
                                p.project_name,
                                p.project_profile,
                                p.project_status,
                                p.totalbudget,
                            };
                VModuleProject vp = null;
                foreach(var row in table.ToList())
                {
                    vp=new VModuleProject();
                    vp.ID = row.ID;
                    vp.category_id = row.category_id;
                    vp.category_name = row.CategoryName;
                    vp.customer_name = row.customer_name;
                    vp.deliverydate = row.deliverydate;
                    vp.IsTimeOut = row.IsTimeOut;
                    vp.leader_id = row.leader_id;
                    vp.leader_name = row.FullName;
                    vp.plancycle_enddate = row.plancycle_enddate;
                    vp.plancycle_startdate = row.plancycle_startdate;
                    vp.project_address = row.project_address;
                    vp.project_code = row.project_code;
                    vp.project_level = row.project_level;
                    vp.project_name = row.project_name;
                    vp.project_profile = row.project_profile;
                    vp.project_status = row.project_status;
                    vp.totalbudget = row.totalbudget;

                    listproject.Add(vp);
                }
            }
            Count = listproject.Count;

            return listproject.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

    }
}
