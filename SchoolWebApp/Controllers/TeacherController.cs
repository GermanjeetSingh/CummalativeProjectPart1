using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolWebApp.Models;
using System;
using Newtonsoft.Json;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolWebApp.Controllers
{
    public class TeacherController : Controller
    {
        // GET: /<controller>/
        public IActionResult List()
        {
            IEnumerable<Teacher> teachers = null;
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5001/api/");

                var response = httpClient.GetAsync("TeacherData/all");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    string data = result.Content.ReadAsStringAsync().Result;
                    teachers = JsonConvert.DeserializeObject<IEnumerable<Teacher>>(data);
                }
                else
                {
                    teachers = Enumerable.Empty<Teacher>();
                    ModelState.AddModelError(string.Empty, "No teachers found");
                }
            }
            return View(teachers);
        }
        public IActionResult Show(int id)
        {
            TeacherClasses tc = null;
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:5001/api/");

                var response = httpClient.GetAsync("TeacherData/" + id);
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    string data = result.Content.ReadAsStringAsync().Result;
                    tc = JsonConvert.DeserializeObject<TeacherClasses>(data);
                }
                else
                {
                    tc = null;
                    ModelState.AddModelError(string.Empty, "No teacher found");
                }
            }
            return View(tc);
        }

        public IActionResult Search(int type, string searchParam)
        {
            IEnumerable<Teacher> teachers = null;

            if (type >= 1 && type <= 3)
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("http://localhost:5001/api/");
                    var response = httpClient.GetAsync(string.Format("TeacherData/search/{0}/{1}", type, searchParam));
                    response.Wait();
                    var result = response.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        string data = result.Content.ReadAsStringAsync().Result;
                        teachers = JsonConvert.DeserializeObject<IEnumerable<Teacher>>(data);
                    }
                    else
                    {
                        teachers = Enumerable.Empty<Teacher>();
                    }
                }
            }
            return View(teachers);
        }

    }
}
