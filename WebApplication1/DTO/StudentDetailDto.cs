using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DTO
{
    public class StudentDetailDto
    {
        public Student student { get; set; }
        public List<TeacherSubject> teacherSubject { get; set; }
        public string class_name { get; set; }
    }
}
