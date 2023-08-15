using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.IServices;
using WebApplication1.Models;

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
        public Teacher addTeacherMethod(String teacher) { return teacherService.addTeacher(teacher); }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/teacher/teachers")]
        public List<Teacher> getAllTeachers() { return teacherService.getAllTeacher(); }

        [HttpGet]
        [Route("[action]")]
        [Route("/api/teacher/getteacher")]
        public Teacher getTeacherById(int id) { return teacherService.getTeacherById(id); }

    }
}
