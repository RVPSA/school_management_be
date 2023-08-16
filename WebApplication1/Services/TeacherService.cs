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
    public class TeacherService : ITeacherService
    {
        private readonly AppDbContext _appDbContext;
        public TeacherService(AppDbContext appDbContext) { _appDbContext = appDbContext; }
        public Teacher addTeacher(TeacherDto teacher) {
            Teacher teacher1 = new Teacher();
            teacher1.first_name = teacher.first_name;
            teacher1.last_name = teacher.last_name;
            teacher1.contact_number = teacher.contact_number;
            teacher1.email = teacher.email;

            _appDbContext.Add(teacher1);
            _appDbContext.SaveChanges();

            AllocatedClassroom allocatedClassroom = new AllocatedClassroom();
            allocatedClassroom.classroom_Id = teacher.classroom_Id;
            allocatedClassroom.teacher_Id = teacher1.teacher_Id;

            _appDbContext.Add(allocatedClassroom);
            _appDbContext.SaveChanges();

            AllocatedSubject allocatedSubject = new AllocatedSubject();
            allocatedSubject.subject_Id = teacher.subject_Id;
            allocatedSubject.teacher_Id = teacher1.teacher_Id;

            _appDbContext.Add(allocatedSubject);
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

        public List<Classroom> getAllocateClassRoom(int teacherId) {
            List<Classroom> classrooms = new List<Classroom>();

           var allocatedClassrooms = _appDbContext.allocation_classroom.ToList();

            foreach (var item in allocatedClassrooms) {
                if (item.teacher_Id == teacherId) {
                    classrooms.Add(_appDbContext.classroom.Find(item.classroom_Id));
                }
            }
            
            return classrooms;
        }
        public List<Subject> getAllocateSubject(int teacherId) {
            List<Subject> subjects = new List<Subject>();

            var allocatedSubjects = _appDbContext.allocation_subject.ToList();

            foreach (var item in allocatedSubjects) {
                if (item.teacher_Id == teacherId) {
                    subjects.Add(_appDbContext.ssubject.Find(item.subject_Id));
                }
            }

            return subjects;
        }
    }
}
