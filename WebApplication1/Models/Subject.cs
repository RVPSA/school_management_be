using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Subject
    {   [Key]
        public int subject_Id { get; set; }
        public string subject_name { get; set; }
    }
}
