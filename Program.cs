using System;
using System.Collections.Generic;

class Program
{
    static List<Contact> contacts = new List<Contact>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n=== Contact Manager ===");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. List Contacts");
            Console.WriteLine("3. Search Contact");
            Console.WriteLine("4. Search Contact by Phone");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
switch (choice)
{
            case "1":
                AddContact();
                break;
            case "2":
                ListContacts();
                break;
            case "3":
                SearchContact();
                break;
            case "4":
                SearchContactByPhone();
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
}

            }
        }
    }
    // Add a new contact to the list
    static void AddContact()
    {
        Console.Write("Enter Name: ");
        var name = Console.ReadLine();

        Console.Write("Enter Email: ");
        var email = Console.ReadLine();

        Console.Write("Enter Phone: ");
        var phone = Console.ReadLine();

        contacts.Add(new Contact { Name = name, Email = email, Phone = phone });
        Console.WriteLine("Contact added successfully!");
    }
    // List all contacts in the list
    static void ListContacts()
    {
        Console.WriteLine("\n=== Contact List ===");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
    // Search for a contact by name
    static void SearchContact()
    {
        Console.Write("Enter Name to Search: ");
        var name = Console.ReadLine();

        var foundContacts = contacts.FindAll(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        if (foundContacts.Count > 0)
        {
            Console.WriteLine("\n=== Search Results ===");
            foreach (var contact in foundContacts)
            {
                Console.WriteLine(contact);
            }
        }
        else
        {
            Console.WriteLine("No contacts found.");
        }
    }
    // Search for a contact by phone
    static void SearchContactByPhone()
{
    Console.Write("Enter Phone to Search: ");
    var phone = Console.ReadLine();

    var foundContacts = contacts.FindAll(c => c.Phone.Contains(phone));
    if (foundContacts.Count > 0)
    {
        Console.WriteLine("\n=== Search Results ===");
        foreach (var contact in foundContacts)
        {
            Console.WriteLine(contact);
        }
    }
    else
    {
        Console.WriteLine("No contacts found.");
    }
}

}

