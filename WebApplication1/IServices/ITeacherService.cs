using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.IServices
{
    public interface ITeacherService
    {
        public string addTeacher(string teacher);
        public string getAllTeacher();

        public string getTeacherById(string teacherId);
    }
}
