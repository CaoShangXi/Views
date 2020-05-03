using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Infrastructure
{
    /// <summary>
    /// 自定义视图类
    /// </summary>
    public class DebugDataView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            //输出路由数据信息
            Write(writer,"---Routing Data---");
            foreach (string key in viewContext.RouteData.Values.Keys)
            {
                Write(writer,"Key:{0},Value:{1}",key,viewContext.RouteData.Values[key]);
            }

            //输出视图数据信息
            Write(writer, "---View Data---");
            foreach (string key in viewContext.ViewData.Keys)
            {
                Write(writer, "Key:{0},Value:{1}", key, viewContext.ViewData[key]);
            }
        }

        private void Write(TextWriter writer,string template,params object[]values)
        {
            writer.Write(string.Format(template,values)+"<p/>");
        }
    }
}