using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DTO
{
    public class StudentDto
    {
        public int student_Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string contact_person { get; set; }
        public int contact_number { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public int age { get; set; }
        public int classroom_Id { get; set; }
    }
}
