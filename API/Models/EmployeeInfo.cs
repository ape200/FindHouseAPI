using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class EmployeeInfo //员工表
    {
        [Key]
        public int EId { get; set; }
        public string Eno { get; set; }
        public string Password { get; set; }
        public string EName { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }
    }
}
