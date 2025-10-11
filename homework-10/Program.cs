using System;
using System.Collections.Generic;
using System.Data;

// Task 1
//interface IAnimal
//{
//    void MakeSound();
//}

//class Dog : IAnimal
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Woof!");
//    }
//}

//class Cat : IAnimal
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Meow!");
//    }
//}

// Task 2
//interface IVehicle
//{
//    public string model  { get; set; }
//    public int year { get; set; }
//    void Start();
//}

//class car : IVehicle
//{
//    public string model { get; set; }
//    public int year { get; set; }
//    public car(string model, int year)
//    {
//        this.model = model;
//        this.year = year;
//    }
//    public void Start()
//    {
//        Console.WriteLine($"The car {model} from {year} is starting.");
//    }
//}   

// Task 3
//interface IReadable { 
//    void Read();

//}

//interface IWritable
//{
//    void Write();
//}
//class Document : IReadable, IWritable
//{
//    public void Read()
//    {
//        Console.WriteLine("Reading the document...");
//    }

//    public void Write()
//    {
//        Console.WriteLine("Writing to the document...");
//    }
//}

// Task 4
//interface IPaymentProcessor
//{
//    void ProcessPayment(decimal amount);
//}

//class CreditCardPayment : IPaymentProcessor
//{
//    public void ProcessPayment(decimal amount)
//    {
//        Console.WriteLine($"Processing credit card payment of ${amount:F2}...");
//    }
//}

//class PayPalPayment : IPaymentProcessor
//{
//    public void ProcessPayment(decimal amount)
//    {
//        Console.WriteLine($"Processing PayPal payment of ${amount:F2}...");
//    }


//Task 5
//interface ILogger
//{
//    void Log(string message);


//    void LogWithTime(string message)
//    {
//        Console.WriteLine($"[{DateTime.Now}] {message}");
//    }
//}

//class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine(message);
//    }
//}

//task 6
//interface IShape
//{
//    double GetArea();
//}

//class Rectangle : IShape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double GetArea()
//    {
//        return Width * Height;
//    }
//}

//class Circle : IShape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public double GetArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}



class Program
    {
        static void Main()
        {   //  Task 1 
            //List<IAnimal> animals = new List<IAnimal>
            //{
            //    new Dog(),
            //    new Cat()
            //};

        //foreach (IAnimal animal in animals)
        //{
        //    animal.MakeSound();
        //}

        // Task 2
        //     IVehicle myVehicle = new car("Honda", 2021);
        //    car car = new car("Toyota", 2020);  
        //    car.Start();
        //    myVehicle.Start();

        //task 3
        //Document doc = new Document();
        //doc.Read();
        //doc.Write();

        // Task 4
        //Console.Write("Enter payment method (credit/paypal): ");
        //string method = Console.ReadLine()?.ToLower();

        //Console.Write("Enter amount: ");
        //decimal amount = Convert.ToDecimal(Console.ReadLine());

        //IPaymentProcessor processor;

        //if (method == "credit")
        //{
        //    processor = new CreditCardPayment();
        //}
        //else if (method == "paypal")
        //{
        //    processor = new PayPalPayment();
        //}
        //else
        //{
        //    Console.WriteLine("Invalid payment method.");
        //    return;
        //}

        //processor.ProcessPayment(amount);

        // Task 5
        //ILogger logger = new ConsoleLogger();
        //logger.Log("This is a log message.");
        //logger.LogWithTime("This is a log message with timestamp.");
        // Task 6
        //List<IShape> shapes = new List<IShape>
        //    {
        //        new Rectangle(4, 5),
        //        new Circle(3),
        //        new Rectangle(2.5, 6)
        //    };

        //double totalArea = 0;

        //foreach (IShape shape in shapes)
        //{
        //    totalArea += shape.GetArea();
        //}

        //Console.WriteLine($"Total area of all shapes: {totalArea:F2}");

    }
}
