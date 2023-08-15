using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AllocatedSubject
    {   [Key]
        public int location_sub_Id { get; set; }
        public int teacher_Id { get; set; }
        public int subject_Id { get; set; }
    }
}
