using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.IServices
{
    public interface IStudent
    {
        Student addStudent(StudentDto student);
        Student updateStudent(StudentDto student);

        string deleteStudent(int studentId);

        Student getStudent(int studentId);
    }
}
