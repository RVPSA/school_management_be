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
        public StudentDetailDto getStudent(int studentId) {
            Student student = _appDbContext.student.Find(studentId);

            List<TeacherSubject> teacherSubjects = new List<TeacherSubject>();
            string class_name = _appDbContext.classroom.Find(student.classroom_Id).classroom_name;

            var classrooms = _appDbContext.allocation_classroom.ToList();
            foreach(var item in classrooms)
            {
                if (item.classroom_Id == student.classroom_Id) {
                    TeacherSubject teacherSubject = new TeacherSubject();

                    var teacher = _appDbContext.teacher.Find(item.teacher_Id);
                    
                    teacherSubject.first_name = teacher.first_name;
                    teacherSubject.last_name = teacher.last_name;

                    var subjects = _appDbContext.allocation_subject.ToList();
                    foreach (var item1 in subjects) {
                        if (item1.teacher_Id == teacher.teacher_Id) {
                            var subject = _appDbContext.ssubject.Find(item1.subject_Id);
                            teacherSubject.subject_name = subject.subject_name;
                            break;
                        }
                    }
                    teacherSubjects.Add(teacherSubject);
                }
            }

            StudentDetailDto studentDetail = new StudentDetailDto();
            studentDetail.student = student;
            studentDetail.teacherSubject = teacherSubjects;
            studentDetail.class_name = class_name;




            return studentDetail;
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
