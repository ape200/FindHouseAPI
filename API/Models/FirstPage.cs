using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class FristPage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //主键id
        public int F_id { get; set; }
        /// 热点名称
        public string Hpt_Name { get; set; }
        /// <summary>
        /// 热点图片
        /// </summary>
        public string Hpt_Image { get; set; }
        /// <summary>
        /// 热点地址
        /// </summary>
        public string Hpt_Site { get; set; }
        /// <summary>
        /// 热点面积
        /// </summary>
        public string Hpt_Ara { get; set; }
        /// <summary>
        /// 热点价格
        /// </summary>
        public string Hpt_Prc { get; set; }
        /// <summary>
        /// 热点标签
        /// </summary>
        public string Hpt_Sta { get; set; }

    }
}
