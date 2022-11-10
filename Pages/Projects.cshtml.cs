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
                    Title = "Concurrent Calculations with Lock Protection Using C#",
                    Description = "Contains three methods: one to synchronously sum every method from 1 to 10 billion, one to synchronously sum from 1 to 100 million, and last, " +
                    "a methed which asynchronously calls the method which sums to 100 million 100 times, but alters each method so that the first sums from 1 to 100 million, the next from 100 million + 1 to 200 million, 200 million + 1 to 300 million, and so forth, up to 10 billion." +
                    "Asynchronous calculations resulted in about 6 fold increase in runtime.",
                    Year = 11/2022,
                    Technologies = new List<string>(){"C#", "Visual Studio"}
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
                },
                new Project()
                {
                    Title = "Interactive C# Loan Calculator Console Application",
                    Description = "Interactive loan calculator console application utilziing detail-oriented exception handling and extensive user interaction.",
                    Year = 10/2022,
                    Technologies = new List<string>(){"C#", "Visual Studio"}
                },
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
                    Title = "Python Swimmer Application",
                    Description = "Enter a name, gender, and age to swim with a Python Swimmer object utilizing object-oriented design, overriding, and inheritence within the Python Turtle library.",
                    Year = 03/2022,
                    Technologies = new List<string>(){"Python"}
                },
                new Project()
                {
                    Title = "Python Disease Data in the US",
                    Description = "Python console application which draws from large data bank and permits the user to search for disease data in the United States between the years 1928 and 2011;" +
                    "The user can enter a request for information about any combination of disease, state, and/or year, and will be shown information pertaining to the valid search parameters.",
                    Year = 02/2022,
                    Technologies = new List<string>(){"Python"}
                }
            }; // end create Projects property (list of Project objects)
        } // end OnGet()
    } // end class ProjectsModel
} // end namespace DanWienerResume.Pages
