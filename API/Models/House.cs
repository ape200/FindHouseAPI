using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class House
    {
        [Key]
        public int Hid { get; set; }
        public string Hname { get; set; }

    }
}
