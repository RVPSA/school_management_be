
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.IServices;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ClassroomService:IClassroomService
    {
        private readonly AppDbContext _appDbContext;
        public ClassroomService(AppDbContext appDbContext) { _appDbContext = appDbContext; }

        //Add a class
        public Classroom addClassMethod(string className) {
            Classroom classroom = new Classroom();
            classroom.classroom_name = className;
            _appDbContext.Add(classroom);
            _appDbContext.SaveChanges();
            
            return classroom;
            
        }

        //Get All class
        public List<Classroom> getAllClassRoom() {
            List<Classroom> classrooms = _appDbContext.classroom.ToList();

            return classrooms;
        }

        //Get Class by id
        public Classroom getClassRoomById(int id) {
            Classroom classroom = _appDbContext.classroom.Find(id);
            return classroom;
        }

    }
}
