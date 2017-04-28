using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZDSoft.LMS.Web.Controllers
{
    /// <summary>
    /// basecontroller 用于处理加载菜单 过滤器 在basecontroller中获取所有要加载的菜单
    /// </summary>
    public class BaseController : Controller
    {
        
        //
        // GET: /Base/

        public ActionResult Index()
        {
            return View();
        }

    }
}
