using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class rental
    {
        public int ID { get; set; }
        public string Name { get; set; }      //小区名称
        public string Title { get; set; }    //标题
        public string proportion { get; set; }  //面积
        public int charter { get; set; }      //租金
        public int sort { get; set; }      //排序
        public string state { get; set; }   //状态

    }
}
