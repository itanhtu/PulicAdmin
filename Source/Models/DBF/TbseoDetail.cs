﻿using System;
using System.Collections.Generic;

namespace Source.Models.DBF
{
    public partial class TbseoDetail
    {
        public int SeodetailId { get; set; }
        public Guid? SeoGuid { get; set; }
        public string Objectguid { get; set; }
        public string SeodetailContent { get; set; }
        public DateTime? SeoModifieddate { get; set; }
        public int? SeoId { get; set; }

        public Tbseo Seo { get; set; }
    }
}
