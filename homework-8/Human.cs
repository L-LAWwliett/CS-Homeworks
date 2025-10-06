using System;

public class Human
{
    string firstName;
    string lastName;
    byte age;
    string personalNumber;
    string phoneNumber;
    string email;

    public string FirstName
    {
        get => firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("First name is required.");
            if (value.Length > 50)
                throw new ArgumentException("First name must not exceed 50 characters.");
            firstName = value;
        }
    }

    public string LastName
    {
        get => lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name is required.");
            if (value.Length > 50)
                throw new ArgumentException("Last name must not exceed 50 characters.");
            lastName = value;
        }
    }

    public byte Age
    {
        get => age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be positive.");
            age = value;
        }
    }

    public string PersonalNumber
    {
        get => personalNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Personal number is required.");
            if (value.Length != 11)
                throw new ArgumentException("Personal number must be exactly 11 digits.");
            personalNumber = value;
        }
    }

    public string PhoneNumber
    {
        get => phoneNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number is required.");
            if (value.Length != 9)
                throw new ArgumentException("Phone number must be exactly 9 digits.");
            phoneNumber = value;
        }
    }

    public string Email
    {
        get => email;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email is required.");
            if (!value.Contains("@") || !value.Contains("."))
                throw new ArgumentException("Email must contain '@' and '.'.");
            if (value.StartsWith("@") || value.EndsWith("@"))
                throw new ArgumentException("Email must not start or end with '@'.");
            if (value.IndexOf('.') < value.IndexOf('@'))
                throw new ArgumentException("'.' must not appear before '@' in email.");
            email = value;
        }
    }

    public Human(string firstName, string lastName, byte age, string personalNumber, string phoneNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        PersonalNumber = personalNumber;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayInfoInConsole()
    {
        Console.WriteLine($"{FirstName} {LastName}, Age: {Age}, Personal#: {PersonalNumber}, Phone: {PhoneNumber}, Email: {Email}");
    }
}

