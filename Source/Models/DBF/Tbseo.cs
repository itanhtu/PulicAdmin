using System;
using System.Collections.Generic;

namespace Source.Models.DBF
{
    public partial class Tbseo
    {
        public Tbseo()
        {
            TbseoDetail = new HashSet<TbseoDetail>();
        }

        public int SeoId { get; set; }
        public string SeoName { get; set; }
        public string SeoUrl { get; set; }
        public DateTime? SeoModifieddate { get; set; }

        public ICollection<TbseoDetail> TbseoDetail { get; set; }
    }
}
