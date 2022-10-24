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

        public void OnGet()
        {
            GithubUsername = "danwiener";

            Projects = new List<Project> {
                new Project()
                {
                    Title = "Explorella",
                    Description = "A large scale travelling application built to help plan your destination and itinerary on your next trip! Built on React, Node, Express, and MongoDB.",
                    Year = 2019
                },
                new Project()
                {
                    Title = "Cypher Clothing",
                    Description = "A large scale e-commerce clothing store application. Built with Razor Pages and SQLite.",
                    Year = 2019
                },
                new Project()
                {
                    Title = "Password Box",
                    Description = "A password manager Chrome plugin used to create and safely store all your passwords! Built with Javascript and HTML.",
                    Year = 2020
                }
            }; // end create Projects property (list of Project objects)
        } // end OnGet()
    } // end class ProjectsModel
} // end namespace DanWienerResume.Pages
