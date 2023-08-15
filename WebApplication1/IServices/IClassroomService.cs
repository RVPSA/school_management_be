using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.IServices
{
    public interface IClassroomService
    {
        Classroom addClassMethod(string className);
        List<Classroom> getAllClassRoom();

        Classroom getClassRoomById(int id);
    }
}
