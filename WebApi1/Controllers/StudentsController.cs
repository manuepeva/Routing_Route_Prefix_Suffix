using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WEBAPI.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
         static List<Student> students = new List<Student>()
        {
            new Student() {Id = 1, FirstName = "Jose", LastName = "t"},
            new Student() {Id = 2, FirstName = "Lucho", LastName = "t"},
            new Student() {Id = 3, FirstName = "Riki", LastName = "t"},
        };


        public IEnumerable<StudentsController> Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }


        public HttpResponseMessage Post(StudentsController student)
        {
            students.Add(students);
            var response = Request.CreateResponse(HttpStatusCode.Created);
            return response;

        }
    }
}