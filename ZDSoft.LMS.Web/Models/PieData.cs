using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZDSoft.LMS.Web.Models
{
    /// <summary>
    /// 饼图数据源(本类中的属性值，为保证与图表控件的属性一直，需要使用全部小写)
    /// </summary>
    public class PieData
    {
        //值
        public decimal value { get; set; }
        //名称
        public string name { get; set; }
    }
}