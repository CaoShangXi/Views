using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Views.Infrastructure;

namespace Views
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //删除集合中的其它视图引擎
            ViewEngines.Engines.Clear();
            //注册自定义视图引擎
            ViewEngines.Engines.Add(new DebugDataViewEngine());
            //将视图引擎插入到集合的第一个位置，以使能被优先执行
            //ViewEngines.Engines.Insert(0, new DebugDataViewEngine());
        }
    }
}
