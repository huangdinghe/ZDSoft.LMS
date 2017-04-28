using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZDSoft.LMS.Web.Models
{
    /// <summary>
    /// 柱状图数据源(本类中的属性值，为保证与图表控件的属性一直，需要使用全部小写)
    /// </summary>
    public class HistogramDatas
    {
        //名称
        public string name { get; set; }
        //数据
        public List<int> data { get; set; }
        //类型
        public string type { get; set; }
    }
}