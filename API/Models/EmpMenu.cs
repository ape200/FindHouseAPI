using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    /// <summary>
    /// 员工菜单表(主要用于给员工分配权限,而不是给角色分配)
    /// </summary>
    public class EmpMenu
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int EMid { get; set; }
        /// <summary>
        /// 员工主键
        /// </summary>
        public int Eid { get; set; }
        /// <summary>
        /// 菜单主键
        /// </summary>
        public int Mid { get; set; }
    }
}
