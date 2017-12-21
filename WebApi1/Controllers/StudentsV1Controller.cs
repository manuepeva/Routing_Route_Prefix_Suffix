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
        static List<StudentsV1> students = new List<StudentsV1>()
       {
           new StudentsV1() {Id = 1, FirstName = "Lucho", LastName = "Quedaza"},
           new StudentsV1() {Id = 2, FirstName = "Lucho", LastName = "Quedaza"},
           new StudentsV1() {Id = 3, FirstName = "Lucho", LastName = "Quedaza"},
       };

        public IEnumerable<StudentsV1> Get()
        {
            return students;
        }
        public StudentsV1 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}