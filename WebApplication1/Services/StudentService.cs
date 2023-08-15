using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IServices;

namespace WebApplication1.Services
{
    public class StudentService:IStudent

    {
        public string addStudent(String student) {
            return "response comming from service layer";
        }
        public string getStudent(string student) {
            return "response get student method";
        }

        public string updateStudent(string student) {
            return "response update student";
        }
        public string deleteStudent(string student)
        {
            return "response delete student";
        }
    }
}
