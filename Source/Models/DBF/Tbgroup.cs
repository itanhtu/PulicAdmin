using System;
using System.Collections.Generic;

namespace Source.Models.DBF
{
    public partial class Tbgroup
    {
        public Tbgroup()
        {
            Tbadmin = new HashSet<Tbadmin>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? GroupPosition { get; set; }
        public string GroupDepcription { get; set; }
        public int? GroupPemissionnumber { get; set; }
        public DateTime? GroupDatemodified { get; set; }
        public bool? GroupFullcontrol { get; set; }
        public string GroupCode { get; set; }

        public ICollection<Tbadmin> Tbadmin { get; set; }
    }
}
