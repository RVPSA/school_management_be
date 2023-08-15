using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly AppDbContext _appDbContext;
        public TeacherService(AppDbContext appDbContext) { _appDbContext = appDbContext; }
        public Teacher addTeacher(string teacher) {
            Teacher teacher1 = new Teacher();
            _appDbContext.Add(teacher1);
            _appDbContext.SaveChanges();
            return teacher1;
        }
        public List<Teacher> getAllTeacher()
        {
            List<Teacher> teachers = _appDbContext.teacher.ToList();
            return teachers;
        }
        public Teacher getTeacherById(int teacherId) {
            Teacher teacher = _appDbContext.teacher.Find(teacherId);
            return teacher;
        }
    }
}
