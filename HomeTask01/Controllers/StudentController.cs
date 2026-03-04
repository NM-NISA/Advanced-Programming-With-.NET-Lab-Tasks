using HomeTask01.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeTask01.Controllers
{
    public class StudentController : Controller
    {
        [Route("major/list")]
        public IActionResult List()
        {
            var majors = new List<Major>()
            {
                new Major() {ID = 101, Name = "Nusrat", Department = "CSE", Credits = 135, CGPA = 3.94},
                new Major() {ID = 102, Name = "Prity", Department = "CSE", Credits = 142, CGPA = 3.85},
                new Major() {ID = 103, Name = "Sumaiya", Department = "CSE", Credits = 126, CGPA = 3.95},
                new Major() {ID = 104, Name = "Mim", Department = "CSE", Credits = 138, CGPA = 3.75},
                new Major() {ID = 105, Name = "Mafruha", Department = "CSE", Credits = 140, CGPA = 3.87}
            };
            return View(majors);
        }

        [Route("major/detail")]
        public IActionResult Detail()
        {
            return View();
        }

        [HttpPost]
        [Route("major/detail")]
        public IActionResult Detail(Major major)
        {
            if (major.CGPA < 2.5)
            {
                ModelState.AddModelError("CGPA", "CGPA must be at least 2.5");
            }

            if (ModelState.IsValid)
            { 
                return Redirect("/major/list");
            }
            return View(major);
        }
    }
}
