using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.DTO;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StudentService:IStudent

    {
        private readonly AppDbContext _appDbContext;
        public StudentService(AppDbContext appDbContext) { _appDbContext = appDbContext; }


        public Student addStudent(StudentDto student) {
            Student student1 = new Student();
            student1.first_name = student.first_name;
            student1.last_name = student.last_name;
            student1.contact_person = student.contact_person;
            student1.contact_number = student.contact_number;
            student1.email = student.email;
            student1.dob = DateTime.Parse(student.dob); ;
            student1.age = student.age;
            student1.classroom_Id = student.classroom_Id;


            _appDbContext.Add(student1);
            _appDbContext.SaveChanges();
            return student1;
        }
        public Student getStudent(int studentId) {
            Student student = _appDbContext.student.Find(studentId);
            return student;
        }

        public Student updateStudent(StudentDto student) {
            var student1 = _appDbContext.student.Find(student.student_Id);
            
            student1.contact_person = student.contact_person;
            student1.contact_number = student.contact_number;
            student1.email = student.email;
            //_appDbContext.Add(student1);
            _appDbContext.Update(student1);
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
