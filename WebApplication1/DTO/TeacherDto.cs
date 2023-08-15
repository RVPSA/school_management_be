using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DTO
{
    public class TeacherDto
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int contact_number { get; set; }
        public string email { get; set; }
        public int classroom_Id { get; set; }
        public int subject_Id { get; set; }
    }
}
