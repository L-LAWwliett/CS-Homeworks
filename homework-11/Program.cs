using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\zakar\Source\Repos\CS-Homeworks\homework-11\Customers.csv";

        CustomerServices services = new CustomerServices(filePath);
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Customer Management System ---");
            Console.WriteLine("1. View All Customers");
            Console.WriteLine("2. View Single Customer");
            Console.WriteLine("3. Add Customer");
            Console.WriteLine("4. Update Customer");
            Console.WriteLine("5. Delete Customer");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    List<Customer> customers = services.GetAllCustomers();
                    if (customers.Count == 0)
                    {
                        Console.WriteLine("No customers found.");
                    }
                    else
                    {
                        for (int i = 0; i < customers.Count; i++)
                        {
                            Console.WriteLine(customers[i].ToString());
                        }
                    }
                    break;

                case "2":
                    Console.Write("Enter Customer ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Customer single = services.GetSingleCustomer(id);

                    if (single != null)
                        Console.WriteLine(single.ToString());
                    else
                        Console.WriteLine("Customer not found.");
                    break;

                case "3":
                    Customer newCustomer = new Customer();
                    Console.Write("Name: ");
                    newCustomer.Name = Console.ReadLine();
                    Console.Write("Identity Number: ");
                    newCustomer.IdentityNumber = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    newCustomer.PhoneNumber = Console.ReadLine();
                    Console.Write("Email: ");
                    newCustomer.Email = Console.ReadLine();
                    Console.Write("Type (0 = Individual, 1 = Company): ");
                    newCustomer.Type = int.Parse(Console.ReadLine());

                    int newId = services.AddCustomer(newCustomer);
                    Console.WriteLine("Customer added with ID: " + newId);
                    break;

                case "4":
                    Console.Write("Enter Customer ID to update: ");
                    int updateId = int.Parse(Console.ReadLine());
                    Customer existing = services.GetSingleCustomer(updateId);

                    if (existing == null)
                    {
                        Console.WriteLine("Customer not found.");
                    }
                    else
                    {
                        Console.Write("Name (" + existing.Name + "): ");
                        string name = Console.ReadLine();
                        if (name != "") existing.Name = name;

                        Console.Write("Identity Number (" + existing.IdentityNumber + "): ");
                        string idNum = Console.ReadLine();
                        if (idNum != "") existing.IdentityNumber = idNum;

                        Console.Write("Phone Number (" + existing.PhoneNumber + "): ");
                        string phone = Console.ReadLine();
                        if (phone != "") existing.PhoneNumber = phone;

                        Console.Write("Email (" + existing.Email + "): ");
                        string email = Console.ReadLine();
                        if (email != "") existing.Email = email;

                        Console.Write("Type (" + existing.Type + "): ");
                        string typeInput = Console.ReadLine();
                        if (typeInput != "") existing.Type = int.Parse(typeInput);

                        int updated = services.UpdateCustomer(existing);
                        if (updated == 1)
                            Console.WriteLine("Customer updated successfully.");
                    }
                    break;

                case "5":
                    Console.Write("Enter Customer ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    int result = services.DeleteCustomer(deleteId);
                    if (result == 1)
                        Console.WriteLine("Customer deleted.");
                    else
                        Console.WriteLine("Customer not found.");
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
