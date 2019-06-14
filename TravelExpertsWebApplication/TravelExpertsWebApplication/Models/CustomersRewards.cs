using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class CustomersRewards
    {
        public int CustomerId { get; set; }
        public int RewardId { get; set; }
        public string RwdNumber { get; set; }

        public Customers Customer { get; set; }
        public Rewards Reward { get; set; }
    }
}
