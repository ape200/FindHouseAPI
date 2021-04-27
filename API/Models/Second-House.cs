using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Second_House
    {
        [Key]
        //二手房id
        public int Se_id { get; set; }
        //二手房名称
        public string Se_Name { get; set; }
        //二手房类型
        public string Se_Type { get; set; }
        //二手房产权年限
        public int Se_YearXian { get; set; }
        //状态
        public bool Se_State { get; set; }
        //房源概况
        public string Se_SurveyFang { get; set; }
        //小区概况
        public string Se_SurveyQu { get; set; }
        //房价参考
        public decimal Se_ReferencePrice { get; set; }
        //房价总价
        public decimal Se_HousePrise { get; set; }

        //热度
        public int Se_Heat { get; set; }
        //时间
        public DateTime Se_Time { get; set; }
        //图片
        public string Se_Img { get; set; }
        //面积
        public string Se_Area { get; set; }
        //户型
        public string Se_HouesType { get; set; }

    }
}
