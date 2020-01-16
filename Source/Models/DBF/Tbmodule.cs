using System;
using System.Collections.Generic;

namespace Source.Models.DBF
{
    public partial class Tbmodule
    {
        public Tbmodule()
        {
            Tbform = new HashSet<Tbform>();
        }

        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int? ModuleParent { get; set; }
        public int? ModuleLevel { get; set; }
        public int? ModulePosition { get; set; }
        public string ModuleIcon { get; set; }
        public string ModuleDepcription { get; set; }
        public string ModuleLink { get; set; }
        public string ModuleCode { get; set; }
        public DateTime? ModuleDatemodified { get; set; }

        public ICollection<Tbform> Tbform { get; set; }
    }
}
