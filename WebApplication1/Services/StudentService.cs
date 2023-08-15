using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StudentService:IStudent

    {
        private readonly AppDbContext _appDbContext;
        public StudentService(AppDbContext appDbContext) { _appDbContext = appDbContext; }


        public Student addStudent(String student) {
            Student student1 = new Student();
            _appDbContext.Add(student1);
            _appDbContext.SaveChanges();
            return student1;
        }
        public Student getStudent(int studentId) {
            Student student = _appDbContext.student.Find(studentId);
            return student;
        }

        public Student updateStudent(string student) {
            var student1 = _appDbContext.student.Find(1);

            //need to implement
            _appDbContext.SaveChanges();

            return student1;
        }
        public string deleteStudent(int studentId)
        {
            var student = _appDbContext.student.Find(studentId);
            _appDbContext.student.Remove(student);
            _appDbContext.SaveChanges();

            return "response delete student";
        }
    }
}
