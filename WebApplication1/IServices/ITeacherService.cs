using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.IServices
{
    public interface ITeacherService
    {
        public Teacher addTeacher(string teacher);
        public List<Teacher> getAllTeacher();

        public Teacher getTeacherById(int teacherId);
    }
}
