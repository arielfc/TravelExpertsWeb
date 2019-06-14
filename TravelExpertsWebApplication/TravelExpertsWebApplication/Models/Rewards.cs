using System;
using System.Collections.Generic;

namespace TravelExpertsWebApplication.Models
{
    public partial class Rewards
    {
        public Rewards()
        {
            CustomersRewards = new HashSet<CustomersRewards>();
        }

        public int RewardId { get; set; }
        public string RwdName { get; set; }
        public string RwdDesc { get; set; }

        public ICollection<CustomersRewards> CustomersRewards { get; set; }
    }
}
