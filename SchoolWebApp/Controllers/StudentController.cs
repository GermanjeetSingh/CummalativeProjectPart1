using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SchoolWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolWebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult List()
        {
            IEnumerable<Student> students = null;
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5001/api/");

                var response = httpClient.GetAsync("StudentData");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    string data = result.Content.ReadAsStringAsync().Result;
                    students = JsonConvert.DeserializeObject<IEnumerable<Student>>(data);
                }
                else
                {
                    students = Enumerable.Empty<Student>();
                    ModelState.AddModelError(string.Empty, "No students found");
                }
            }
            return View(students);
        }

    }
}
