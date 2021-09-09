using System;
using System.Data;

namespace AddressBook_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address book program using Linq");
            AddressBookTable addressBookTable = new AddressBookTable();
            DataTable dataTable = addressBookTable.AddAddressBookDataTable();
            addressBookTable.DisplayContacts(dataTable);
        }
    }
}
