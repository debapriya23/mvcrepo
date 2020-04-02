using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication22.Models
{
    public class product
    {
        [Key]
        public int pid { get; set; }
        [Required]
        public  String pname { get; set; }
        [Required]
        public  int pprice { get; set; }
        public int pdesc{ get; set; }



    }
}
