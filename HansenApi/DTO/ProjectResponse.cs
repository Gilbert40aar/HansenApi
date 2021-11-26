using HansenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.DTO
{
    public class ProjectResponse
    {
        public int projectId { get; set; }
        public string projectTitle { get; set; }
        public int genreId { get; set; }
        public Genre Genre { get; set; }
        public string projectYear { get; set; }
        public string descripTion { get; set; }
        public string developer { get; set; }
    }
}
