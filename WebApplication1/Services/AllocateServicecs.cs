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
    public class AllocateServicecs:IAllocateService
    {
        private readonly AppDbContext _appDbContext;
        public AllocateServicecs(AppDbContext appDbContext) { _appDbContext = appDbContext; }


        public AllocatedClassroom allocateClassroom(AllocateClassroom allocateClassroom) {
            AllocatedClassroom allocatedClassroom = new AllocatedClassroom();
            allocatedClassroom.classroom_Id = allocateClassroom.classroom_Id;
            allocatedClassroom.teacher_Id = allocateClassroom.teacher_Id;
            _appDbContext.Add(allocatedClassroom);
            _appDbContext.SaveChanges();
            return allocatedClassroom;
        }

        public string deallocateClassroom(AllocateClassroom allocateClassroom) {
            var allocatedClassroom = _appDbContext.allocation_classroom.ToList();
            foreach (var item in allocatedClassroom) {
                if (item.classroom_Id == allocateClassroom.classroom_Id && item.teacher_Id == allocateClassroom.teacher_Id) 
                { _appDbContext.allocation_classroom.Remove(item);
                    _appDbContext.SaveChanges();
                    return "Deallocation successfull!";
                }
            }
            return "Deallocation fail";
        }

        public AllocatedSubject allocateSubject(AllocateSubject allocateSubject) {
            AllocatedSubject allocatedSubject = new AllocatedSubject();
            allocatedSubject.subject_Id = allocateSubject.subject_Id;
            allocatedSubject.teacher_Id = allocateSubject.teacher_Id;
            _appDbContext.Add(allocatedSubject);
            _appDbContext.SaveChanges();
            return allocatedSubject;
        }
        public string deallocateSubject(AllocateSubject allocateSubject) {
            var allocatedSubjects = _appDbContext.allocation_subject.ToList();
            foreach (var item in allocatedSubjects)
            {
                if (item.subject_Id == allocateSubject.subject_Id && item.teacher_Id == allocateSubject.teacher_Id)
                {
                    _appDbContext.allocation_subject.Remove(item);
                    _appDbContext.SaveChanges();
                    return "Deallocation successfull!";
                }
            }
            return "Deallocation fail";
        }
    }
}
