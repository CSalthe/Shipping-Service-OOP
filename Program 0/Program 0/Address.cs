// ID: D7090
// Program: 0
// Due: September 10th 2018
// CIS 200-01
// This class establishes Address objects which conatin the infromation one would need to send an individual a package, (Name, Address1, Address2(optional), City, State, Zip Code). 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project_0
{
    class Address
    {
        private const string DEF_ADDRESS2 = " "; // default value of address2 if address2 is not provided
        private const int MINZIP = 0; // minimum value of Zip property
        private const int MAXZIP = 99999; // maximum value of Zip property
        private string name; // backing field for Name property 
        private string address1; // backing field for Address1 property
        private string address2; // backing field for Address2 property
        private string city; // backing field for City property
        private string state; // backing field for State property
        private int zip; // backing field for zip property

        // Precondition: 
        //    !string.IsNullOrWhiteSpace(name) (string must contain some value)
        //    !string.IsNullOrWhiteSpace(address1) (string must contain some value)
        //    !string.IsNullOrWhiteSpace (address2) (string must contain some value or whitespace)
        //    !string.IsNullOrWhiteSpace(city) (string must contain some value)
        //    !string.IsNullOrWhiteSpace(state) (string must contain some value)
        //    !string.IsNullOrWhiteSpace(zip) (string must contain some value)
        // Post-Condition: Initializes the values of every property in the Address class upon object creation
        public Address(string name, string address1, string address2, string city, string state, int zip)
        {
            Name = name; // Initializes Name 
            Address1 = address1; // Initializes Address1
            Address2 = address2; // Initializes Address2
            City = city; // Initializes City
            State = state; // Initializes State
            Zip = zip; // Initializes Zip

        }
        // Precondition: 
        //    !string.IsNullOrWhiteSpace(name) (string must contain some value)
        //    !string.IsNullOrWhiteSpace(address1) (string must contain some value)
        //    !string.IsNullOrEmpty (address2) (string must contain some value or whitespace)
        //    !string.IsNullOrWhiteSpace(city) (string must contain some value)
        //    !string.IsNullOrWhiteSpace(state) (string must contain some value)
        //    !string.IsNullOrWhiteSpace(zip) (string must contain some value)
        // Post-Condition: Initializes the values of every property in the Address class upon object creation, assigns default value to address 2
        public Address(string name, string address1, string city, string state, int zip)
        {
            Name = name; // Initializes Name 
            Address1 = address1; // Initializes Address1
            Address2 = DEF_ADDRESS2; // Initializes Address2 w/ default value (no address 2 provided in this constructor)
            City = city; // Initializes City
            State = state; // Initializes State
            Zip = zip; // Initializes Zip

        }

        public string Name
        {
            // Precondition: None
            // Post-Condition: returns value in Name backing field
            get { return name; }
            // Precondition: !string.IsNullOrWhiteSpace(value) (string must contain some value)
            // Post-Condition: argument sent becomes the value of Name property for referenced object
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Name requires a valid name");
                }
                else
                {
                    name = value;
                }
            }
        }
        public string Address1
        {
            // Precondition: None
            // Post-Condition: returns value in Address1 backing field
            get { return address1; }
            // Precondition: !string.IsNullOrWhiteSpace(value) (string must contain some value)
            // Post-Condition: argument sent becomes the value of Address1 property for referenced object
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Address 1 requires a valid address");
                }
                else
                {
                    address1 = value;
                }
            }
        }
        public string Address2
        {
            // Precondition: None
            // Post-Condition: returns value in Address2 backing field
            get { return address2; }
            // Precondition: !string.IsNullOrWhiteSpace(value) (string must contain some value)
            // Post-Condition: argument sent becomes the value of Address2 property for referenced object
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Please Enter A Valid Address for Address2");
                }
                else
                {
                    address2 = value;
                }
            }

        }
        public string City
        {
            // Precondition: None
            // Post-Condition: returns value of City in backing field
            get { return city; }
            // Precondition: !string.IsNullOrWhiteSpace(value) (string must contain some value)
            // Post-Condition: argument sent becomes the value of City property for referenced object
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("City requires a valid City");
                }
                else
                {
                    city = value;
                }
            }
        }
        public string State
        {
            // Precondition: None
            // Post-Condition: returns value of State in backing field
            get { return state; }
            // Precondition: !string.IsNullOrWhiteSpace(value) (string must contain some value)
            // Post-Condition: argument sent becomes the value of State property for referenced object
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("State requires a valid State");
                }
                else
                {
                    state = value;
                }
            }
        }
        public int Zip
        {
            // Precondition: None
            // Post-Condition: returns value of State in backing field
            get { return zip; }
            // Precondition: MINZIP <= value <= MAXZIP
            // Post-Condition: argument sent becomes the value of Zip property for referenced object
            set
            {
                if (value >= MINZIP || value <= MAXZIP)
                {
                    zip = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Zip requires a valid Zip-Code");
                }

            }
        }
        // Precondition: None
        // Post-Condition: Depending upon which constructor was called when instantiating an address object this method will return a formatted string that includes an Address2 value or a formatted string that does not contain an Address2 value
        public override string ToString()
        {
            if (Address2 == DEF_ADDRESS2)
            {
                return ($"{Environment.NewLine}Name:{Name}{Environment.NewLine}Address 1:{Address1} , Address 2:{Address2}{Environment.NewLine}City:{City} , State:{State} , Zip Code:{Zip:D5}");
            }
            else
            {
                return ($"{Environment.NewLine}Name:{Name}{Environment.NewLine}Address 1:{Address1} {Environment.NewLine}Address 2:{Address2}{Environment.NewLine}City:{City} , State:{State} , Zip Code:{Zip:D5}");
            }
        }

    }
}

