using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi1.Models;

namespace WEBAPI.Controllers
{
   
    public class StudentsController : ApiController
    {
        static List<Students> students = new List<Students>()
       {
           new Students() {Id = 1, FirstName = "Lucho", LastName = "Quedaza"},
           new Students() {Id = 2, FirstName = "Lucho", LastName = "Quedaza"},
           new Students() {Id = 3, FirstName = "Lucho", LastName = "Quedaza"},
       };

        public IHttpActionResult Get()
        {
            return Ok(students);

        }
        public IHttpActionResult Get(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if(student == null)
            {
                return Content(HttpStatusCode.NotFound, "Studentin nicht brauchen");
            }
            return Ok(student);
        }
    }
}