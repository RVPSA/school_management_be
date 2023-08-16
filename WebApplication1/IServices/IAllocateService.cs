using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.IServices
{
    public interface IAllocateService
    {
        AllocatedClassroom allocateClassroom(AllocateClassroom allocateClassroom);
        string deallocateClassroom(AllocateClassroom allocateClassroom);

        AllocatedSubject allocateSubject(AllocateSubject allocateSubject);
        string deallocateSubject(AllocateSubject allocateSubject);
    }
}
