using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.IServices;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService teacherService;
        private readonly AppDbContext _context;
        public TeacherController(ITeacherService iTeacherService, AppDbContext context)
        {
            teacherService = iTeacherService;
            _context = context;
        }

        [HttpPost]
        [Route("[action]")]
        [Route("/api/teacher/addteacher")]
        public string addTeacherMethod() { return teacherService.addTeacher("Add teacher"); }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/teacher/teachers")]
        public string getAllTeachers() { return teacherService.getAllTeacher(); }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/teacher/getteacher")]
        public string getTeacherById() { return teacherService.getTeacherById("t1"); }

    }
}
