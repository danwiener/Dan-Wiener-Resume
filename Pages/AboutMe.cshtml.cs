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
            Description = "I love coding; I grew up with a father who was a computer science professor " +
                "(PhD), a mother who has a Master’s degree in computer science, and half brothers each " +
                "with an M.S. as well who became successful developers in the Bay Area, so I have been " +
                "exposed to tech my whole life. My parents largely helped foster my love for tech from when " +
                "I got my first Windows PC at 3 or 4 years old, and I have never stopped utilizing technology " +
                "since, having grown up reading online content, playing games, editing photos, producing " +
                "videos, or watching my dad grade C# projects in Visual Studio. I have a deep admiration " +
                "for Microsoft and the impact its products have had on the world, fundamentally changing the " +
                "way people do things and improving the lives of millions of people. I have connected with " +
                "numerous Microsoft employees as well, whom have solidified this feeling. Having developed my " +
                "passion for coding a few years ago, born out of my love for tech, it would be a dream come " +
                "true to be apart of this team and make meaningful products to contribute to others’ lives.\r\n";

            Email = "henrik.wiener@outlook.com";
        }
    }
}
