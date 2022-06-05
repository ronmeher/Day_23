using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingCollectionLibrary
{
    public class Records
    {

        List<Contacts> records = new List<Contacts>();


        //Displaying all COntact of AddressBook
        public void ToPrint()
        {
            if (records.Count == 0)
            {
                Console.WriteLine("AddressBook is empty, please add some records or Address");
            }
            int reco = 1;
            foreach (var person in records.ToList())
            {
                Console.WriteLine("\n\nRecord - " + reco);
                Console.WriteLine("First Name : " + person.firstName);
                Console.WriteLine("Last Name : " + person.lastName);
                Console.WriteLine("Address : " + person.address);
                Console.WriteLine("City : " + person.city);
                Console.WriteLine("State : " + person.state);
                Console.WriteLine("Email : " + person.email);
                Console.WriteLine("Zip code : " + person.zip);
                Console.WriteLine("Phone Number : " + person.phoneNumber);
                reco++;

            }
        }

        //Adding record to address book
        public void AddRecord()
        {
            Contacts contact = new Contacts();

            Console.WriteLine("Enter First Name of The Contact to checkfor Duplication: ");
            string name = Console.ReadLine();

            //Checking For Duplication 
            bool flag = records.Any(x => string.Equals(x.firstName, name));

            if (flag)
            {
                Console.WriteLine("The given Name is already exist");
            }
            else
            {
                //If not then adding new contact
                Console.WriteLine("No Duplication found \n");

                Console.WriteLine("Enter your First Name : ");
                contact.firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name : ");
                contact.lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address : ");
                contact.address = Console.ReadLine();
                Console.WriteLine("Enter your City Name : ");
                contact.city = Console.ReadLine();
                Console.WriteLine("Enter your State Name : ");
                contact.state = Console.ReadLine();
                Console.WriteLine("Enter your Zip Code : ");
                contact.zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Phone Number : ");
                contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Email Address: ");
                contact.email = Console.ReadLine();

                records.Add(contact);
            }
        }
        //Serch the person by city name
        public void CheckByCity()
        {
            Console.WriteLine("Please enter the city name to find person: ");
            string ecity = Console.ReadLine();
            List<Contacts> contacts = records.FindAll(x => (x.city == ecity));

            //Checking for Availability
            if (contacts.Count == 0)
            {
                Console.WriteLine("No person found in that City");
            }
            else
            {
                Console.WriteLine("Total number of Contacts are: " + contacts.Count);
                Console.WriteLine("Person details are: ");
                int rc = 1;
                foreach (Contacts contact in contacts)
                {
                    Console.WriteLine("\n\nRecord:-" + rc);
                    Console.WriteLine("\nFirst name is: " + contact.firstName);
                    Console.WriteLine("Last name is: " + contact.lastName);
                    Console.WriteLine("Address : " + contact.address);
                    Console.WriteLine("City : " + contact.city);
                    Console.WriteLine("State : " + contact.state);
                    Console.WriteLine("Email : " + contact.email);
                    Console.WriteLine("Zip code : " + contact.zip);
                    Console.WriteLine("Phone Number : " + contact.phoneNumber);
                    rc++;
                }
            }
        }
        //Search the person by State name
        public void CheckByState()
        {

            Console.WriteLine("Please enter the State to find person: ");
            string estate = Console.ReadLine();
            List<Contacts> contacts1 = records.FindAll(x => (x.state == estate));

            //Checking for availability
            if (contacts1.Count == 0)
            {
                Console.WriteLine("No person found in that state");
            }
            else
            {
                Console.WriteLine("Total Number of Contacts are: " + contacts1.Count);
                Console.WriteLine("Person details are: ");
                int rc = 1;
                foreach (Contacts contact in contacts1)
                {
                    Console.WriteLine("\nFirst name is: " + contact.firstName);
                    Console.WriteLine("Last name is: " + contact.lastName);
                    Console.WriteLine("Address : " + contact.address);
                    Console.WriteLine("City : " + contact.city);
                    Console.WriteLine("State : " + contact.state);
                    Console.WriteLine("Email : " + contact.email);
                    Console.WriteLine("Zip code : " + contact.zip);
                    Console.WriteLine("Phone Number : " + contact.phoneNumber);
                    rc++;
                }
            }
        }
    }
}
