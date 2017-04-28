using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZDSoft.LMS.Web.Models
{
    /// <summary>
    /// 图表数据模型
    /// </summary>
    public class ChartModel
    {
        //x轴序列值
        public List<string> XAxis { get; set; }
        //图例
        public List<string> Legend { get; set; }
        //柱状图数据源
        public List<HistogramDatas> HistogramDatas { get; set; }
        //饼图数据源
        public List<PieData> PieDatas { get; set; }
    }
}