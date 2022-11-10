using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DanWienerResume.Pages

{
    public class AboutMeModel : PageModel
    {
        public string Email { get; set; }
        public string Description { get; set; }
        public void OnGet()
        {
            Description = "After 4 years in the Marine Corps, I am currently committed to pursuing my dream of becoming a software engineer." +
                "\r\n\r\nI love coding; I grew up with a father who was a computer science professor (PhD), a mother who has a Master’s degree, " +
                "and half brothers who became successful developers in the Bay Area, so I have been exposed to tech my whole life. My parents largely " +
                "helped foster my love for tech from when I got my first computer at 3 or 4 years old, and I have never stopped utilizing technology since. " +
                "\r\n\r\nIt feels only natural, then, that I fell in love with software development as soon as I picked up my first Intro to Python book and " +
                "started teaching myself coding, before I started work toward my Bachelor's in computer science and achieved my goal of attending the " +
                "Microsoft Software & Systems Academy (MSSA).\r\n\r\nI strive to be better every single day, and constantly learn more through voracious " +
                "reading of books or online content, and spending nearly all my waking moments coding. Technology is constantly evolving, and I am drawn to " +
                "the challenge of constantly having something new to learn, from my (hopefully one day perfect) extensive JavaFX fantasy football application, " +
                "to my ASP .NET Core resume website, or my web-scraping pin-guessing Node.js app. \r\n\r\nI currently utilize C#, HTML, CSS, JavaScript, and " +
                "SQL, and ASP .NET Core, with experience in Java and Python as well. I am grateful to be here, and look forward to what the future holds.\r\n";

            Email = "henrik.wiener@outlook.com";
        }
    }
}
