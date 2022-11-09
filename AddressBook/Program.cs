using System;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Create  2. Edit  3.Delete  4.Display  5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.CreateContact();
                        break;
                    case 2:
                        Console.Write("Enter FirstName and LastName to edit ");
                        string edit = Console.ReadLine();   
                        addressBook.Edit(edit);
                        break;
                    case 3:
                        Console.Write("Enter FirstName and LastName to Delte ");
                        string delete = Console.ReadLine();
                        addressBook.DeleteContacts(delete);
                        break;
                    case 4:
                        addressBook.DisplayList();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
