using System;
using System.Collections.Generic;

namespace Source.Models.DBF
{
    public partial class Tbvideo
    {
        public int VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoSummary { get; set; }
        public string VideoImage { get; set; }
        public string VideoLink { get; set; }
        public string VideoContent { get; set; }
        public DateTime? VideoCreatedate { get; set; }
        public DateTime? VideoDatemodified { get; set; }
        public int? LangguageId { get; set; }
        public int? Position { get; set; }
    }
}
