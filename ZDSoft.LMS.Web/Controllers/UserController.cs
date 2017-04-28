using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZDSoft.LMS.Core;
using ZDSoft.LMS.Domain;
using ZDSoft.LMS.Service;
using ZDSoft.LMS.Web.Apps;

namespace ZDSoft.LMS.Web.Controllers
{
    public class UserController : Controller
    {
        //test
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getall()
        {
            return View();
        }

        #region 登录
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            //md5加密
            model.Password = AppHelper.EncodeMd5(model.Password);//用MD5加密

            //访问数据库，根据用户名和密码获取用户信息
            IUserService userService = Container.Instance.Resolve<IUserService>();
            Domain.User loginedUser = userService.Login(model.Account, model.Password);
            if (loginedUser != null)//当用户名和密码正确时
            {
                //保存用户登录信息
                AppHelper.LoginedUser = loginedUser;
                //获取当前登录对象的角色信息，待用
                //IList<Role> roleList = loginedUser.Roles;

                //页面跳转到主页面
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //如果登录不成功，则向用户提示错误信息
                ViewBag.ErrorMsg = "用户名或密码错误。";
                return View(model);
            }

        }
        #endregion

    }
}
