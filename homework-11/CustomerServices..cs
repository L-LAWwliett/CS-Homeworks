using System;
using System.Collections.Generic;
using System.IO;

public class CustomerServices
{
    private string filePath;

    public CustomerServices(string path)
    {
        filePath = path;
    }

    
    public List<Customer> GetAllCustomers()
    {
        List<Customer> customers = new List<Customer>();

        if (!File.Exists(filePath))
        {
            return customers;
        }

        string[] lines = File.ReadAllLines(filePath);

        
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split(',');
            if (parts.Length < 6)
                continue;

            Customer c = new Customer();
            c.Id = int.Parse(parts[0]);
            c.Name = parts[1];
            c.IdentityNumber = parts[2];
            c.PhoneNumber = parts[3];
            c.Email = parts[4];
            c.Type = int.Parse(parts[5]);

            customers.Add(c);
        }

        return customers;
    }

    
    public Customer GetSingleCustomer(int id)
    {
        List<Customer> customers = GetAllCustomers();

        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i].Id == id)
            {
                return customers[i];
            }
        }

        return null;
    }

    public int AddCustomer(Customer model)
    {
        List<Customer> customers = GetAllCustomers();

        int newId = 1;
        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i].Id >= newId)
            {
                newId = customers[i].Id + 1;
            }
        }

        model.Id = newId;
        customers.Add(model);
        SaveToFile(customers);

        return newId;
    }

    public int UpdateCustomer(Customer model)
    {
        List<Customer> customers = GetAllCustomers();
        bool found = false;

        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i].Id == model.Id)
            {
                customers[i].Name = model.Name;
                customers[i].IdentityNumber = model.IdentityNumber;
                customers[i].PhoneNumber = model.PhoneNumber;
                customers[i].Email = model.Email;
                customers[i].Type = model.Type;
                found = true;
                break;
            }
        }

        if (found)
        {
            SaveToFile(customers);
            return 1;
        }

        return 0;
    }

    public int DeleteCustomer(int id)
    {
        List<Customer> customers = GetAllCustomers();
        bool deleted = false;

        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i].Id == id)
            {
                customers.RemoveAt(i);
                deleted = true;
                break;
            }
        }

        if (deleted)
        {
            SaveToFile(customers);
            return 1;
        }

        return 0;
    }

    private void SaveToFile(List<Customer> customers)
    {
        List<string> lines = new List<string>();
        lines.Add("Id,Name,IdentityNumber,PhoneNumber,Email,Type");

        for (int i = 0; i < customers.Count; i++)
        {
            Customer c = customers[i];
            string line = c.Id + "," + c.Name + "," + c.IdentityNumber + "," + c.PhoneNumber + "," + c.Email + "," + c.Type;
            lines.Add(line);
        }

        File.WriteAllLines(filePath, lines.ToArray());
    }
}
