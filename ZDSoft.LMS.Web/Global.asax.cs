using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ZDSoft.LMS.Core;

namespace ZDSoft.LMS.Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        #region Fields

        private Container container;

        #endregion
        protected void Application_Start()
        {
            //初始化castle
            IConfigurationSource source = System.Configuration.ConfigurationManager.GetSection("activerecord") as IConfigurationSource;
            ActiveRecordStarter.Initialize(typeof(ZDSoft.LMS.Domain.User).Assembly, source);
            AreaRegistration.RegisterAllAreas();


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            container = Container.Instance;
           
        }
        /// <summary>
        /// 关闭容器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_End(object sender, EventArgs e)
        {
            container.Dispose();
        }
    }
}