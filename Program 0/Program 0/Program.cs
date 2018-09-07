// ID: D7090
// Program: 0
// Due: September 10th 2018
// CIS 200-01
// This class instantiates multiple Address and Letter Objects, then adds the created objects to a list and prints each object to the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project_0
{
    class Program
    {
        //precondition: None
        //Postcondition: 4 Address Objects are created, the Address objects are plugged into Letter objects w/ decmial numeric values, those Letter objects are stored in a list of Parcel objects then each element of the parcel list is printed.
        static void Main(string[] args)
        {
            // creates 4 Address objects
            Address a1 = new Address("chris", "1245 Glen ave", "louisville", "ky", 12);
            Address a2 = new Address("james", "1245 abe street", "10203 Brand rd", "san diego", "ca", 91125);
            Address a3 = new Address("gerbo", "1245 broadrun ave", "boulder", "co", 15443);
            Address a4 = new Address("cline", "1245 native ave", "louisville", "ky", 43325);

            // creates 3 letter objects using Address objects and decimal numeric values
            Letter l1 = new Letter(a1, a2, 2);
            Letter l2 = new Letter(a3, a4, 12);
            Letter l3 = new Letter(a1, a4, 7);

            // List of Letter Ojbects Stored as Parcel Objects, to show Letter is a Parcel
            List<Parcel> p1 = new List<Parcel>();
            p1.Add(l1);
            p1.Add(l2);
            p1.Add(l3);

            //Prints Properties of each Letter object, again showing Letter is a Parcel
            foreach (Parcel element in p1)
            {
                WriteLine(element); // prints each element in p1 list
            }

        }
    }
}
