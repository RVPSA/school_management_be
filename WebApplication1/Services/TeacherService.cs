using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class TeacherService:ITeacherService
    {
        public string addTeacher(string teacher) {
            return "Response from add teacher";
        }
        public string getAllTeacher()
        {
            return "Response from get all teacher";
        }
        public string getTeacherById(string teacherId) {
            return "Response from get teacher by Id";
        }
    }
}
