using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;//添加词句引用，用于设置Remote验证属性

namespace ZDSoft.LMS.Domain
{
    [ActiveRecord]
    public class Role:EntityBase
    {
        /// <summary>
        /// 角色名
        /// </summary>
        [Property(NotNull=true,Length=20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "名称")]
        //[Remote("AjaxCheckRoleName", "Role", AdditionalFields = "Id", ErrorMessage = "该帐号已存在")]//远程验证登录是否存在，AdditionalFields表示除了当前要获取RoleName属性值外，还需要从视图中获取的其他属性值
        public string RoleName { get; set; }

        /// <summary>
        /// 是否激活，默认应该为true
        /// </summary>
        [Property(NotNull = true)]
        [Required]
        [Display(Name = "激活")]
        public bool IsActive { get; set; }

        /// <summary>
        /// 当前角色拥有的用户
        /// </summary>
        [HasAndBelongsToMany(typeof(User), Table = "User_Role", ColumnKey = "RoleID",Inverse=false, ColumnRef = "UserID" ,Lazy = true)]
        public IList<User> Users { get; set; }  

        /// <summary>
        /// 当前角色可以操作的功能
        /// </summary>
        //[HasAndBelongsToMany(typeof(SystemFunction), 
        //    Table = "Role_SystemFunction", 
        //    ColumnKey = "RoleID", 
        //    ColumnRef = "SystemFunctionID",
        //    Inverse=false,
        //    Lazy = true)]
        //public IList<SystemFunction> SystemFunctions { get; set; }

        //#region 扩展属性，用于非orm映射
        //public bool IsChecked
        //{
        //    get;
        //    set;
        //}
        //#endregion
    }
}
