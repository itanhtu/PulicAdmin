using Microsoft.AspNetCore.Http;
using Source.Models.DBF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectContent { get; set; }
        public string ProjectImage { get; set; }
        public string ProjectLink { get; set; }
        public int? ProjectPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? ServiceId { get; set; }
        public int? LangguageId { get; set; }
        public bool? ProjectHidden { get; set; }
        public int? Position { get; set; }
        public IFormFile Project_UpImage { get; set; }
        public string Project_LinkImage { get; set; }
        public Tbcategory Category { get; set; }
        public Tbservice Service { get; set; }
        public ICollection<Tbimageproject> Tbimageproject { get; set; }
    }
}
