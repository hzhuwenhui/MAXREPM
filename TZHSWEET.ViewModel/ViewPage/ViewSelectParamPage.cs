﻿
 /*  作者：      huwenhui
 *  创建时间：   2012/7/27 10:21:40
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TZHSWEET.Common
{
   public class ViewSelectParamPage
    {
        public string ControllerName { get; set; }

        public string MenuID { get; set; }

        public string AreaName { get; set; }

        public ViewSelectParamPage(HttpContextBase context)
       {
            ControllerName = context.Request["controllerName"];
            MenuID = context.Request["MenuID"];
            AreaName = context.Request["AreaName"];
        }
    }
}
