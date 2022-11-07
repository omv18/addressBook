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
        List<Contact> addressBook = new List<Contact>();
        public void print()
        {
            Console.WriteLine("Contact Derails : " + "\n" + "First Name : " + contact.FirstName + "\n" + "Last Name : " + contact.LastName
                                + "\n" + "Address is : " + contact.Address + "\n" + "City is : " + contact.City + "\n" + "State is : " + contact.State
                                + "\n" + "Zip is : " + contact.Zip + "\n" + "Phone Number is :" + contact.PhoneNumber + "\n" + "Email is : " + contact.Email);
        }
        public void createContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            contact.PhoneNumber = Console.ReadLine();
            contact.Email = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void edit(string name)
        {
            createContact();
            foreach (var contact in addressBook)
            {
                if ((contact.FirstName.Equals(name)) || (contact.LastName.Equals(name)))
                {
                    Console.WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNumber 8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1: 
                            contact.FirstName = Console.ReadLine(); 
                            break;
                        case 2:
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 6:
                            break;
                        case 7:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    print();
                }
            }
        }
    }
}
