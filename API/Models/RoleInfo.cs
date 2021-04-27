using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class RoleInfo //角色表
    {
        [Key]
        public int RId { get; set; }
        public string RName { get; set; }
        public int Level { get; set; }
        public string Remark { get; set; }

    }
}
