using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMidterm
{
    class Customer:PersonV2
    {
        private DateTime customersince;
        private double totalpurchases;
        private Boolean discountmember;
        private int rewardsearned;

        public DateTime CustomerSince
        {
            get
            {
                return customersince;
            }

            set
            {
                customersince = value;
            }
        }

            public double TotalPurchases
            {   
                get
                {
                    return totalpurchases;
                }

                set
                {
                    totalpurchases = value;
                }
            }
        public Boolean DiscountMember
        {
            get
            {
                return discountmember;
            }

            set
            {
                discountmember = value;
            }
        }

        public int RewardsEarned
        {
            get
            {
                return rewardsearned;
            }

            set
            {
                rewardsearned = value;
            }
        }
    }
}
