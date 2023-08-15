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
        public TeacherController(ITeacherService iTeacherService, AppDbContext context) { teacherService = iTeacherService;
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

        [HttpGet]
        [Route("[action]")]
        [Route("/api/teacher/tst")]
        public IActionResult testDb() {
            var car = _context.Car.ToList();
            return Ok(car);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("/api/teacher/car")]
        public IActionResult addCar(Car car) {
            _context.Add(car);
            _context.SaveChanges();
            return Ok(car);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("/api/teacher/bus")]
        public IActionResult addCar(BusDto bus)
        {
            Bus _bus = new Bus();
            _bus.name = bus.name;
            _bus.id = 2;
            _context.Add(_bus);
            _context.SaveChanges();
            return Ok(_bus);
        }

    }
}
