// ID: D7090
// Program: 0
// Due: September 10th 2018
// CIS 200-01
// This abstract Class establishes an origin and destination address to serve as a base class for specific delivery methods that require additonal information. All shipped goods will get origin and destination address's from this abstract class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project_0
{
    abstract class Parcel
    {
        private Address _originAddress; // backing field for Origin Address property
        private Address _destinationAddress; // backing field for Destination Address property

        // Precondition: None (validation performed in Address class)
        // Post-Condition: Initializes the value of each property specified in the Parcel class 
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress; // Initializes OriginAddress 
            DestinationAddress = destinationAddress; // Initializes DestinationAddress
        }
        public Address OriginAddress
        {
            // Precondition: None
            // Post-Condition: returns value for OriginAddress backing field 
            get { return _originAddress; }
            // Precondition: None
            // Post-Condition: assigns value sent to OriginAddress as backing field of OriginAddress
            set { _originAddress = value; }
        }
        public Address DestinationAddress
        {
            // Precondition: None
            // Post-Condition: returns value for DestinationAddress backing field
            get { return _destinationAddress; }
            // Precondition: None
            // Post-Condition: assigns value sent to DestinationAddress as backing field of DestinationAddress
            set { _destinationAddress = value; }
        }

        // Precondition: None
        // Post-Condition: None
        public abstract decimal CalcCost();

        // Precondition: None
        // Post-Condition: Formatted string containing properties of Parcel class is printed 
        public override string ToString()
        {
            return ($"Origin Address:{OriginAddress} {Environment.NewLine}Destination Address:{DestinationAddress} {Environment.NewLine} Cost:{CalcCost():C2}{Environment.NewLine}");
        }
    }
}
