using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Criterion;
using System.ComponentModel.DataAnnotations;
using Castle.ActiveRecord;
using System.Web.Mvc;

namespace ZDSoft.LMS.Domain
{
    [ActiveRecord("SystemUser")]
    public class User : EntityBase  //继承EntityBase，继承的属性和方法
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Property(NotNull = true, Length = 20)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过20个字符")]
        [Display(Name = "用户名")]
        public virtual string UserName { get; set; }

        /// <summary>
        /// 帐户名
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Required(ErrorMessage = "不能为空")]
        [StringLength(20, ErrorMessage = "不能超过50个字符")]
        [Display(Name = "帐号")]
        //[Remote("AjaxCheckAccount", "User", ErrorMessage = "该帐号已存在")]//远程验证登录是否存在，AdditionalFields表示除了当前要获取Account属性值外，还需要从视图中获取的其他属性值
        public virtual string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Property(NotNull = true, Length = 50)]
        [Display(Name = "密码")]
        public virtual string Password { get; set; }

        /// <summary>
        /// 是否激活，默认应该为true
        /// </summary>
        [Property(NotNull = true)]
        [Required]
        [Display(Name = "激活")]
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// 当前用户拥有的角色
        /// </summary>
        [HasAndBelongsToMany(typeof(Role),
            Table = "User_Role",
            ColumnKey = "UserID",
            ColumnRef = "RoleID",
            Cascade = ManyRelationCascadeEnum.None,
            Inverse = false,
            Lazy = true)]
        public virtual IList<Role> Roles { get; set; }
    }
}