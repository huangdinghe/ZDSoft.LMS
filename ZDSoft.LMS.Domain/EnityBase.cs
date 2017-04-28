using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ZDSoft.LMS.Domain
{
    public class EntityBase
    {
        [PrimaryKey(PrimaryKeyType.Identity)]//主键的类型为自增型
        [Display(AutoGenerateField = false)]
        public virtual int ID { get; set; }

        [Property("Version")]
        [Display(AutoGenerateField = false)]
        public virtual int Version { get; set; }
    }
}
