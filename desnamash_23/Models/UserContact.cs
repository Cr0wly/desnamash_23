using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace desnamash_23.Models
{
    public class UserContact
    {
        [Key]
        public string User { get; set; }
        public int ContactPhone { get; set; }
    }
}
