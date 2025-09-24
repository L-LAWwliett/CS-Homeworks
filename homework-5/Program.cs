using System;
class program {

    static void Main(string[] args)
    {

        ////--- Homework-5 Tasks ---
        //int[] arr = { 5, 9, 13, 55, 10 };

        //// Task 1
        //Console.WriteLine("Array Elements:");
        //for (int i = 0; i < arr.Length; i++)
        //    Console.Write(arr[i] + " ");
        //Console.WriteLine();

        //// Task 2
        //int max = arr[0];
        //for (int i = 1; i < arr.Length; i++)
        //    if (arr[i] > max) max = arr[i];
        //Console.WriteLine("Max: " + max);

        //// Task 3
        //int min = arr[0];
        //for (int i = 1; i < arr.Length; i++)
        //    if (arr[i] < min) min = arr[i];
        //Console.WriteLine("Min: " + min);

        //// Task 4
        //int sum = 0;
        //for (int i = 0; i < arr.Length; i++)
        //    sum += arr[i];
        //Console.WriteLine("Sum: " + sum);

        //// Task 5
        //Console.WriteLine("Reversed:");
        //for (int i = arr.Length - 1; i >= 0; i--)
        //    Console.Write(arr[i] + " ");
        //Console.WriteLine();

        //// Task 6
        //int even = 0, odd = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] % 2 == 0) even++;
        //    else odd++;
        //}
        //Console.WriteLine($"Even: {even}, Odd: {odd}");

        //// Task 7
        //Console.Write("Enter a number to search: ");
        //int search = int.Parse(Console.ReadLine());
        //bool found = false;
        //for (int i = 0; i < arr.Length; i++)
        //    if (arr[i] == search) { found = true; break; }
        //Console.WriteLine(found ? "Found!" : "Not Found!");

        //// Task 8
        //int[] copy = new int[arr.Length];
        //for (int i = 0; i < arr.Length; i++)
        //    copy[i] = arr[i];
        //Console.WriteLine("Copied Array: " + string.Join(", ", copy));

        //// Task 9
        //int first = int.MinValue, second = int.MinValue;
        //foreach (int num in arr)
        //{
        //    if (num > first)
        //    {
        //        second = first;
        //        first = num;
        //    }
        //    else if (num > second && num != first)
        //        second = num;
        //}
        //Console.WriteLine("Second Largest: " + second);

        //// Task 10
        //Console.WriteLine("Frequencies:");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    int count = 1;
        //    bool visited = false;
        //    for (int j = 0; j < i; j++)
        //        if (arr[i] == arr[j]) { visited = true; break; }
        //    if (visited) continue;

        //    for (int k = i + 1; k < arr.Length; k++)
        //        if (arr[i] == arr[k]) count++;

        //    Console.WriteLine(arr[i] + " → " + count + " times");
        //}




    // Advanced tasks
        int[] arr = { 10, 5, 1, 15, 7, 50, 9 };
        //task 1
        int n = 2;
        int[] rotated = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
              rotated[(i + n) % arr.Length] = arr[i]; 
        }
        Console.Write("Rotated array: ");
        for (int i = 0; i < rotated.Length; i++) Console.Write(rotated[i] + " ");
        Console.WriteLine();

        //task 2     es ar gviswavlia mara pattern davgugle da principi gasagebi iyo XD 
        int[] bubble = (int[])arr.Clone();
        for (int i = 0; i < bubble.Length - 1; i++)
            for (int j = 0; j < bubble.Length - i - 1; j++)
                if (bubble[j] > bubble[j + 1])
                {
                    int temp = bubble[j];
                    bubble[j] = bubble[j + 1];
                    bubble[j + 1] = temp;
                }
        Console.Write("// Sorted array with bubble sort: ");
        for (int i = 0; i < bubble.Length; i++) Console.Write(bubble[i] + " ");
        Console.WriteLine();

        //task 3
        bool Duplicate = false;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j]) Duplicate = true;
                if (!Duplicate) Console.Write(arr[i] + " ");
            }
        }

        //task 4
        int[] arr1 = { 1, 3, 5 };
        int[] arr2 = { 2, 4, 6 };
        int[] merged = new int[arr1.Length + arr2.Length];
        int m = 0, i1 = 0, i2 = 0;
        while (i1 < arr1.Length && i2 < arr2.Length)
            merged[m++] = (arr1[i1] < arr2[i2]) ? arr1[i1++] : arr2[i2++];
        while (i1 < arr1.Length) merged[m++] = arr1[i1++];
        while (i2 < arr2.Length) merged[m++] = arr2[i2++];
        Console.Write("// Merged array: ");
        for (int i = 0; i < merged.Length; i++) Console.Write(merged[i] + " ");
        Console.WriteLine();

        // Task 5
        int pos = 3, value = 10;
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0, j = 0; i < newArr.Length; i++)
            newArr[i] = (i == pos) ? value : arr[j++];
        Console.Write("Inserted array: ");
        for (int i = 0; i < newArr.Length; i++) Console.Write(newArr[i] + " ");
        Console.WriteLine();

        // Task 6
        int del = 5;
        int[] delArr = new int[arr.Length - 1];
        int idx = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] != del) delArr[idx++] = arr[i];
        Console.Write("// Fixed array: ");
        for (int i = 0; i < idx; i++) Console.Write(delArr[i] + " ");
        Console.WriteLine();

        // Task 7 
        int target = 8;
        Console.WriteLine("// Pairs with sum " + target + ":");
        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] + arr[j] == target)
                    Console.WriteLine(arr[i] + ", " + arr[j]);

        // Task 8 
        bool palindrome = true;
        for (int i = 0; i < arr.Length / 2; i++)
            if (arr[i] != arr[arr.Length - i - 1]) { palindrome = false; break; }
        Console.WriteLine("// Palindrome: " + palindrome);

        // Task 9  
        int[] miss = { 1, 2, 4, 5 }; // Missing 3
        int k = miss.Length + 1;
        int expectedSum = k * (k + 1) / 2;
        int actualSum = 0;
        foreach (int num in miss) actualSum += num;
        Console.WriteLine("// Missing Number: " + (expectedSum - actualSum));

        // Task 10 
        int maxCount = 1, currentCount = 1, element = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1]) currentCount++;
            else currentCount = 1;
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                element = arr[i];
            }
        }
        Console.WriteLine("//dup " + element + " appears " + maxCount + " times in a row");
    }


}