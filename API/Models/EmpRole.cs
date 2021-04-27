using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class EmpRole //员工角色表
    {
        [Key]
        public int Id { get; set; }
        public int RID { get; set; }
        public int EID { get; set; }
    }
}
