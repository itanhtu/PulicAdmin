using System;
using System.Collections.Generic;

namespace Source.Models.DBF
{
    public partial class Tbimageproject
    {
        public int ImageId { get; set; }
        public string ImageLink { get; set; }
        public string ImageTitle { get; set; }
        public string ImageSummary { get; set; }
        public int? ProjectId { get; set; }
        public int? LangguageId { get; set; }
        public int? Position { get; set; }

        public Tbproject Project { get; set; }
    }
}
