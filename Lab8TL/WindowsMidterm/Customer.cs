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
                    if(ValidationLibrary.ismininumValid(value,1)==true)
                    {
                    totalpurchases = value;
                    }
                    else
                    {
                    Feedback = "ERROR: Invalid Purchases Format:";
                }
                    
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
                if (ValidationLibrary.isMinValid(value,0)== true)
                {
                    rewardsearned = value;

                }
                else
                {
                    Feedback = "ERROR: Invalid Rewards Format:";
                }
            }
        }
    }
}
