using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class userNew
    {
        [Key]
        public int Unid { get; set; }
        public int Userid { get; set; }
        public int Newsid { get; set; }
    }
}
