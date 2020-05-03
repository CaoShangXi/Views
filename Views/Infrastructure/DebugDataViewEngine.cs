﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Infrastructure
{
    /// <summary>
    /// 自定义视图引擎
    /// </summary>
    public class DebugDataViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return new ViewEngineResult(new string[] { "No view(Debug Data View Engine)" });
        }


        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName == "DebugData")
            {
                return new ViewEngineResult(new DebugDataView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[] { "No view(Debug Data View Engine)" });
            }
        }

        /// <summary>
        /// 释放视图
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="view"></param>
        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            
        }
    }
}