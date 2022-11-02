using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DanWienerResume.Models
{
    public class Link
    {
        public LinkType Type { get; set; }
        public string LinkedInURL { get; set; }

        public string GitHubURL { get; set; }

        public Link(LinkType linkType)
        {
            this.Type = linkType;
            LinkedInURL = "https://www.linkedin.com/in/henrikwiener/";
            GitHubURL = "https://github.com/danwiener";
        }
    } // end class Link

    public enum LinkType { GitHub, LinkedIn }

} // end namespace DanWienerResume.Models
