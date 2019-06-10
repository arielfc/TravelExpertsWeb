using System;
using System.Collections.Generic;

namespace TravelExpertsWeb.Models
{
    public partial class CustomersRewards
    {
        public int CustomerId { get; set; }
        public int RewardId { get; set; }
        public string RwdNumber { get; set; }
    }
}
