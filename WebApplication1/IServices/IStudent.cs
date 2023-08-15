using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.IServices
{
    public interface IStudent
    {
        Student addStudent(String student);
        Student updateStudent(string student);

        string deleteStudent(int studentId);

        Student getStudent(int studentId);
    }
}
