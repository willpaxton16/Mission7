using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models.ViewModels
{
    public class PageInfo
    {
        public int NumProjects { get; set; }
        public int ProjectsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (NumProjects / ProjectsPerPage) + 1;
        public int otherTotal => (int)Math.Ceiling((double)NumProjects / ProjectsPerPage);
    }
}
