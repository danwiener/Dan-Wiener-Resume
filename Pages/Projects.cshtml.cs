// Projects.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DanWienerResume.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DanWienerResume.Pages
{
    public class ProjectsModel : PageModel
    {

        public List<Project> Projects { get; set; }

        public string GithubUsername { get; set; }

        public Link LinkProp { get; set; }

        public void OnGet()
        {
            GithubUsername = "danwiener";
            LinkProp = new Link(LinkType.GitHub);
            Projects = new List<Project> {
                new Project()
                {
                    Title = "Extensive JavaFX Fantasy Football App",
                    Description = "Fantasy football application using in-depth principles of object-oriented programming and the JavaFX GUI framework, robust exception and event handling, attention to detail in every facet." +
                    "Goal is to one day perfect this, perhaps get licensing and connect it to the NFL API for use of real team and player names. Short term goal is to adopt and translate this app into .NET MAUI framework utilizing SQL" +
                    "Server backend or aforementioned API for practice building a fullstack application.",
                    Year = 08/2022,
                    Technologies = new List<string>(){"JavaFX", "Java"}
                },
                new Project()
                {
                    Title = "ASP.NET Personal Resume Website Using C# and HTML in Razor Syntax",
                    Description = "My personal resume hosted on a simple ASP.NET website, and a foray into ASP.NET Razor pages.",
                    Year = 10/2022,
                    Technologies = new List<string>(){".NET", "Visual Studio", "Razor Pages", "C#"}
                },
                new Project()
                {
                    Title = "Node.js GuessThePin.com Robotic Process Automation App",
                    Description = "Foray into Node.js using Puppeteer library to navigate to GuessThePin.com in a headless state and continue to guess a 4 digit pin until the pin is correctly guessed, displaying the number of guesses it took on the console.",
                    Year = 10/2022,
                    Technologies = new List<string>(){"Node.js", "JavaScript", "Puppeteer Library"}
                }
            }; // end create Projects property (list of Project objects)
        } // end OnGet()
    } // end class ProjectsModel
} // end namespace DanWienerResume.Pages
