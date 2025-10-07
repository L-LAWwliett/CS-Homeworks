namespace Homework9;
using System;

//--- easy task ---
//abstract class Animal
//{
//    public string Name { get; set; }

//    public Animal(string name)
//    {
//        if (string.IsNullOrWhiteSpace(name))
//            throw new ArgumentException("Animal must have a name.");

//        Name = name;
//    }

//    public abstract void MakeSound();
//}

//class Dog : Animal
//{
//    public Dog(string name) : base(name) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Dog barks: Woof!");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name) : base(name) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Cat meows: Meow!");
//    }
//}

class Program
{
    static void Main()
    {
        //--- easy task ---
        //try
        //{
        //    Animal[] animals = new Animal[]
        //    {
        //        new Dog("Qoria"),
        //        new Cat("Zoro"),

        //    };

        //    foreach (Animal animal in animals)
        //    {
        //        animal.MakeSound();
        //    }
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine($"Error: {ex.Message}");
        //}

     

       
            CheckingAccount nikaAccount = new CheckingAccount("CHK-1010", 1500);
            CheckingAccount anaAccount = new CheckingAccount("CHK-1011", 900);
            LoanAccount giorgiLoan = new LoanAccount("LOAN-2020", 3000);

            TransactionService service = new TransactionService();

            Console.WriteLine("Initial Account States:");
            Console.WriteLine(nikaAccount);
            Console.WriteLine(anaAccount);
            Console.WriteLine(giorgiLoan);
            Console.WriteLine();

            try
            {
                service.Transfer(nikaAccount, anaAccount, 400);   
                service.Transfer(anaAccount, giorgiLoan, 300);    
                service.Transfer(nikaAccount, giorgiLoan, 600);   

                
            
           }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nFinal Account States:");
                Console.WriteLine(nikaAccount);
                Console.WriteLine(anaAccount);
                Console.WriteLine(giorgiLoan);
            }
        }
    }


