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
    public class SubjectController : ControllerBase
    { private readonly ISubjectService _IsubjectService;
        public SubjectController(ISubjectService subjectService) {
            _IsubjectService = subjectService;
        }

        [HttpPost]
        [Route("/api/subject/addsubject")]
        public Subject addSubjectMethod(string subjectName) { return _IsubjectService.addSubject(subjectName); }

        [HttpGet]
        [Route("/api/subject/getallsubject")]
        public List<Subject> getAllSubjectMethod() {
            return _IsubjectService.getAllSubject();
        }

        [HttpGet]
        [Route("/api/subject/getsubjectbyname")]
        public Subject getSubjectByNameMethod(String subjectName) {
            return _IsubjectService.getSubjectByName(subjectName);
        }
    }
}
