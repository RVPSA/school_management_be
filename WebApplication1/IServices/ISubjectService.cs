using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.IServices
{
    public interface ISubjectService
    {
        Subject addSubject(string subjectName);

        List<Subject> getAllSubject();

        Subject getSubjectByName(string subjectName);
    }
}
