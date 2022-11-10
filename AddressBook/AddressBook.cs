using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    internal class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> addressDict = new Dictionary<string, List<Contact>>();
        public void DisplayList()
        {
            int count = 0;
            foreach (var contact in addressBook)
            {
                Console.WriteLine("Contact Derails : "+count+ "\n" + "First Name : " + contact.FirstName + "\n" + "Last Name : " + contact.LastName
                    + "\n" + "Address is : " + contact.Address + "\n" + "City is : " + contact.City + "\n" + "State is : " + contact.State
                    + "\n" + "Zip is : " + contact.Zip + "\n" + "Phone Number is :" + contact.PhoneNumber + "\n" + "Email is : " + contact.Email);
                count++;
            }
        }
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.Write("Enter  FirstName: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter  LastName: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter  Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter  City: ");
            contact.City = Console.ReadLine();
            Console.Write("Enter  State: ");
            contact.State = Console.ReadLine();
            Console.Write("Enter  Zip: ");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter  PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter  Email: ");
            contact.Email = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void Edit(string name)
        {
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
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 7:
                            break;
                        case 8:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 9:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    break;
                }
            }
        }

        public void DeleteContacts(string name)
        {
            try
            {
                foreach (var contact in addressBook.ToList())
                {
                    if ((contact.FirstName.Equals(name)) || (contact.LastName.Equals(name)))
                    {
                        addressBook.Remove(contact);
                    }   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CreateDictionarContact()
        {
            Console.Write("Enter the key :");
            string key = Console.ReadLine();
            addressDict.Add(key, addressBook);
            addressBook = new List<Contact>();
        }
         public void DisplayDict()
        {
            foreach(var data in addressDict)
            {
                Console.WriteLine(data.Key);
                foreach(var contact in data.Value)
                {
                    Console.WriteLine("Contact Derails : \n" + "First Name : " + contact.FirstName + "\n" + "Last Name : " + contact.LastName
                                    + "\n" + "Address is : " + contact.Address + "\n" + "City is : " + contact.City + "\n" + "State is : " + contact.State
                                    + "\n" + "Zip is : " + contact.Zip + "\n" + "Phone Number is :" + contact.PhoneNumber + "\n" + "Email is : " + contact.Email);
                }
            }
        }


    }
}
