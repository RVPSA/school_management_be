using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IServices;

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
        public string addStudentMethod() { return istudentS.addStudent("Add student"); }

        [HttpPut]
        [Route("[action]")]
        [Route("/api/student/updatestudent")]
        public string updateStudentMethod() { return istudentS.updateStudent("Update student"); }

        [HttpDelete]
        [Route("[action]")]
        [Route("/api/student/deletestudent")]
        public string deleteStudentMethod() { return istudentS.deleteStudent("Delete student"); }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/student/getstudent")]
        public string getStudentMethod() { return istudentS.getStudent("Get student"); }
    }
}
