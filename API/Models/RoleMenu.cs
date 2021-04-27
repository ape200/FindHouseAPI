using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class RoleMenu //角色菜单表
    {
        [Key]
        public int Id { get; set; }
        public int RId { get; set; }
        public int MId { get; set; }
    }
}
