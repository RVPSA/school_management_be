using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AllocatedClassroom
    {   [Key]
        public int alocation_cls_Id { get; set; }
        public int teacher_Id { get; set; }

        public int classroom_Id { get; set; }

    }
}
