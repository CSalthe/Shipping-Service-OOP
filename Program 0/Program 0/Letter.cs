// ID: D7090
// Program: 0
// Due: September 10th 2018
// CIS 200-01
// This class is derived from Parcel, Letter adds fixed cost as a property and incldues a concrete CalcCost method which allows for fixed cost to be associated with a Letter object as well as all the public properties in Parcel.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project_0
{
    class Letter : Parcel
    {
        private const int MIN_COST = 0; // minimum value of fixed cost property
        private const int PRICE_ADJUSTMENT = 2; // the number to be multiplied by fixed cost to adjust for pricing differences between regions
        private decimal _fixedCost; // backing field for private Fixed Cost property

        // Precondition:
        // fixedcost > MIN_COST
        // Post-Condition: Initilaizes value of every property specified in Letter class, also adjusts fixed cost relative to market price.
        public Letter(Address originAddress, Address destinationAddress, decimal fixedcost) : base(originAddress, destinationAddress)
        {
            OriginAddress = originAddress; // Initializes OriginAddress 
            DestinationAddress = destinationAddress; // Initilaizes Destination address 
            FixedCost = fixedcost * PRICE_ADJUSTMENT; // Initialzies FixedCost and multiplies the fixed cost by price adjustment to compensate for different markets
        }
        // Precondition: None
        // Post-Condition: returns value of property Fixed Cost
        public override decimal CalcCost()
        {
            return FixedCost;
        }
        private decimal FixedCost
        {
            // Precondition: None
            // Post-Condition: returns value of FixedCost backing field
            get { return _fixedCost; }
            // Precondition: value > MIN_COST
            // Post-Condition: value sent to FixedCost is set to the FixedCost backing field
            set
            {
                if (value < MIN_COST)
                {
                    throw new ArgumentOutOfRangeException("Fixed Cost must contain a positive value");
                }
                else
                {
                    _fixedCost = value;
                }
            }
        }
        // Precondition: None
        // Post-Condition: The formatted string containing all properties in Letter class is printed
        public override string ToString()
        {
            return ($"Origin Address:{OriginAddress}{Environment.NewLine}Destination Address:{DestinationAddress}{Environment.NewLine}Fixed Cost:{FixedCost:C2}{Environment.NewLine}");
        }

    }
}
