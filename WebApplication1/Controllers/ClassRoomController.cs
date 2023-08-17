using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly IClassroomService _IclassroomService;

        public ClassRoomController(IClassroomService classroomService) {
            _IclassroomService = classroomService;
        }

        [HttpPost]
        [Route("/api/addclass")]
        public Classroom addClassMethod(string className) { return _IclassroomService.addClassMethod(className); }

        [HttpGet]
        [Route("/api/getclasses")]
        public List<Classroom> getAllClassRoomMethod() {
            return _IclassroomService.getAllClassRoom();
        }

        [HttpGet]
        [Route("/api/getclassbyid")]
        public Classroom getClassroomById(int Id) {
            return _IclassroomService.getClassRoomById(Id);
        }
    }
}
