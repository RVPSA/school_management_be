using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Classroom
    {   [Key]
        public int classroom_Id { get; set; }
        public string classroom_name { get; set; }
    }
}
