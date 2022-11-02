
// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DanWienerResume.Pages
{
    public class IndexModel : PageModel
    {

        #region Properties
        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Platforms_Framework { get; set; }

        #endregion

        public void OnGet()
        {
            FullName = "Henrik Wiener";
            LinkedInUsername = "henrikwiener";
            YearsOfExperience = 2;
            Languages = new List<string>() { "C#", "Java", "JavaScript", "HTML5", "CSS", "Python", "T-SQL", "Git" };
            Platforms_Framework = new List<string>() { "ASP.NET Core MVC", "Visual Studio", "JavaFX", "Node.js", "SSMS",
                "Azure Data Studio", "Git" };

        }

    }
}