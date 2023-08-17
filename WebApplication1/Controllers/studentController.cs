using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class studentController : ControllerBase
    { private readonly IStudent istudentS;
        public studentController(IStudent istudent) {
            istudentS = istudent;
        }
        
        [HttpGet]
        [Route("[action]")]
        [Route("/api/student/test")]
        public string testMethod() { return "Service is working"; }

        [HttpPost]
        [Route("[action]")]
        [Route("/api/student/addstudent")]
        public Student addStudentMethod(StudentDto studentDto) { return istudentS.addStudent(studentDto); }

        [HttpPut]
        [Route("[action]")]
        [Route("/api/student/updatestudent")]
        public Student updateStudentMethod(StudentDto studentDto) { return istudentS.updateStudent(studentDto); }

        [HttpDelete]
        [Route("[action]")]
        [Route("/api/student/deletestudent")]
        public string deleteStudentMethod(int studentId) { return istudentS.deleteStudent(studentId); }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/student/getstudent")]
        public StudentDetailDto getStudentMethod(int studentId) { return istudentS.getStudent(studentId); }
    }
}
