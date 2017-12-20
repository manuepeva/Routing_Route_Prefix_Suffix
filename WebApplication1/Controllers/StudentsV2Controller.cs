using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class StudentsV2Controller : ApiController
    {
        static List<StudentsV2> students = new List<StudentsV2>()
       {
           new StudentsV2() {Id = 1, FirstName = "Lucho", LastName = "Quedaza", Gender = "Male", City = "Punot"},
           new StudentsV2() {Id = 2, FirstName = "Lucho", LastName = "Quedaza", Gender = "Male", City = "Punot" },
           new StudentsV2() {Id = 3, FirstName = "Lucho", LastName = "Quedaza", Gender = "Male", City = "Punot"},
       };
        
        public IEnumerable<StudentsV2> Get()
        {
            return students;
        }
        
        public StudentsV2 Get(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
