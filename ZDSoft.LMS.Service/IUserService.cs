using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZDSoft.LMS.Domain;

namespace ZDSoft.LMS.Service
{
    public interface IUserService : IBaseService<ZDSoft.LMS.Domain.User>
    {      
        /// <summary>
        /// 定义登录操作的接口方法
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User Login(string account,string password);
    }
}
