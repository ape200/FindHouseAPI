using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        //public string Userimg { get; set; }
        public string Phone { get; set; }
        public int Gid { get; set; }//关注
        public string Sex { get; set; }//性别
        public string photo { get; set; }//图片

    }
}
