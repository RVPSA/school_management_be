using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.IServices
{
    public interface IStudent
    {
        string addStudent(String student);
        string updateStudent(string student);

        string deleteStudent(string student);

        string getStudent(string student);
    }
}
