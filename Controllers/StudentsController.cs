using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using WebAppHttp.Models;

namespace WebAppHttp.Controllers
{
    public class StudentController : ApiController
    {
        Models.Student[] students = new Models.Student[]{
         new  Models.Student {Name="Walter", Class="7A", Address="Address 1", Email="walter@email.com" },
         new Models.Student {Name="Matthew", Class="7A", Address="Address 2", Email="matthew@email.com" },
         new Models.Student {Name="Anne", Class="7A", Address="Address 3", Email="anne@email.com" },
        };

        public IEnumerable<Models.Student> GetAllStudents()
        {
            return students;
        }

        private IHttpActionResult Ok(Student student)
        {
            throw new NotImplementedException();
        }

        private IHttpActionResult DllNotFoundException()
        {
            throw new NotImplementedException();
        }
    }
}

