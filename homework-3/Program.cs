using System;

class Program
{
    static void Main()
    {
        // --- Homework-3 Tasks ---
        // rom gameertianebina davakomentare shegizliat datestvis miznit uncomment gauketot tito-titod.

        // Task 1: 
        /*
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i);
            if (i < 10) Console.Write(" ");
        }
        */

        // Task 2: 
        /*
        int sum = 0;
        for (int i = 1; i <= 100; i++) sum += i;
        Console.WriteLine("Sum = " + sum);
        */

        // Task 3: 
        /*
        for (int i = 1; i <= 20; i += 2)
        {
            Console.Write(i);
            if (i < 19) Console.Write(" ");
        }
        */

        // Task 4: 
        /*
        int n = 5;
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
        */

        // Task 5: 
        /*
        for (int i = 10; i >= 1; i--)
        {
            Console.Write(i);
            if (i > 1) Console.Write(" ");
        }
        */

        // Task 6: 
        /*
        int n = 5;
        int fact = 1;
        for (int i = 2; i <= n; i++) fact *= i;
        Console.WriteLine("Factorial = " + fact);
        */

        // Task 7: 
        /*
        for (int i = 0; i < 10; i++) Console.Write("*");
        */

        // Task 8: 
        /*
        int sum = 0;
        int i = 1;
        while (sum < 50)
        {
            sum += i;
            i++;
        }
        Console.WriteLine("Sum = " + sum);
        */

        // Task 9: 
        /*
        string correct = "1234";
        string input;
        do
        {
            Console.Write("Enter password: ");
            input = Console.ReadLine();
        } while (input != correct);
        Console.WriteLine("Correct!");
        */

        // Task 10: 
        /*
        int num = 121; // change input here
        int original = num;
        int rev = 0;
        while (num > 0)
        {
            rev = rev * 10 + (num % 10);
            num /= 10;
        }
        if (rev == original) Console.WriteLine("Palindrome");
        else Console.WriteLine("Not Palindrome");
        */

        // Task 11: 
        /*
        int n = 7;
        int a = 0, b = 1;
        Console.Write(a);
        if (n > 1) Console.Write(" " + b);
        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            Console.Write(" " + c);
            a = b;
            b = c;
        }
        */
    }
}
