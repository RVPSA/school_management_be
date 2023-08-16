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
    public class AllocateController : ControllerBase
    {
        private readonly IAllocateService _iallocateService;
        public AllocateController(IAllocateService allocateService) { _iallocateService = allocateService; }

        [HttpPost]
        [Route("/api/allocate/classroom")]
        public AllocatedClassroom allocateClassroomMethod(AllocateClassroom allocateClassroom) {
            return _iallocateService.allocateClassroom(allocateClassroom);
        }

        [HttpDelete]
        [Route("/api/allocate/removeclassroom")]
        public string deallocateClassroom(AllocateClassroom allocateClassroom) {
            return _iallocateService.deallocateClassroom(allocateClassroom);
        }


        [HttpPost]
        [Route("/api/allocate/subject")]
        public AllocatedSubject allocateSubjectMethod(AllocateSubject allocateSubject)
        {
            return _iallocateService.allocateSubject(allocateSubject);
        }

        [HttpDelete]
        [Route("/api/allocate/removesubject")]
        public string deallocateSubject(AllocateSubject allocateSubject)
        {
            return _iallocateService.deallocateSubject(allocateSubject);
        }
    }
}
