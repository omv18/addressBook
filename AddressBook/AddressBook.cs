using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        Contact contact = new Contact();

        public void print()
        {
            Console.WriteLine("Contact Derails : " + "\n" + "First Name : " + contact.FirstName + "\n" + "Last Name : " + contact.LastName
                                + "\n" + "Address is : " + contact.Address + "\n" + "City is : " + contact.City + "\n" + "State is : " + contact.State
                                + "\n" + "Zip is : " + contact.Zip + "\n" + "Phone Number is :" + contact.PhoneNumber + "\n" + "Email is : " + contact.Email);
        }
        public void craeteContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            contact.PhoneNumber = Console.ReadLine();
            contact.Email = Console.ReadLine();
            print();
        }
    }
}
