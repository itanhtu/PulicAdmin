﻿using System;
using System.Collections.Generic;

namespace Source.Models.DBF
{
    public partial class Tbcontact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactContent { get; set; }
        public int? ProjectId { get; set; }
    }
}
