using CIS172_TestCoreAppMelton.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CIS172_TestCoreAppMelton.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index(int accessLevel = 1)
        {
            // Sample data for testing purposes
            var students = new List<StudentModel>
            {
                new StudentModel { FirstName = "Alice", LastName = "Johnson", Grade = "A" },
                new StudentModel { FirstName = "Bob", LastName = "Smith", Grade = "B" },
                new StudentModel { FirstName = "Charlie", LastName = "Brown", Grade = "C" }
            };

            // Create and populate the view model
            var viewModel = new AssignmentViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            // Pass the view model to the view
            return View(viewModel);
        }
    }
}
