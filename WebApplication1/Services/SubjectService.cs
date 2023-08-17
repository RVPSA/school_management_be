using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class SubjectService:ISubjectService
    {
        private readonly AppDbContext _appdbContext;

        public SubjectService(AppDbContext appDbContext)
        {
            _appdbContext = appDbContext;
        }

        public Subject addSubject(string subjectName) {
            Subject subject = new Subject();
            subject.subject_name = subjectName;
            _appdbContext.Add(subject);
            int a = _appdbContext.SaveChanges();
            Console.WriteLine("Subject response::: "+a);
            return subject;
        }

        public List<Subject> getAllSubject() {
            List<Subject> subjects = _appdbContext.ssubject.ToList();
            return subjects;
        }

        public Subject getSubjectByName(string subjectName) {
            Subject subject = _appdbContext.ssubject.Find(subjectName);
            return subject;
        }

    }
}
