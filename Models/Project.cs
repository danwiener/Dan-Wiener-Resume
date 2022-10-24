using System.Collections.Generic;

namespace DanWienerResume.Models
{
    public class Project
    {
        #region Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public List<string> Technologies { get; set; } 
        #endregion

    } // end class Project
} // end namespace DanWienerResume.Models
