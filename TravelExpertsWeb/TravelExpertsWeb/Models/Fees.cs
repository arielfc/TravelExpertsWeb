﻿using System;
using System.Collections.Generic;

namespace TravelExpertsWeb.Models
{
    public partial class Fees
    {
        public string FeeId { get; set; }
        public string FeeName { get; set; }
        public decimal FeeAmt { get; set; }
        public string FeeDesc { get; set; }
    }
}
