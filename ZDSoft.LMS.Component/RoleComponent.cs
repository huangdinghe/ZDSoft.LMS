using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZDSoft.LMS.Domain;
using ZDSoft.LMS.Manager;
using ZDSoft.LMS.Service;

namespace ZDSoft.LMS.Component
{
    class RoleComponent : BaseComponent<Role, RoleManager>, IRoleService
    {
    }
}
