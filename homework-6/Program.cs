namespace homework_6
{
    internal class Program
    {
        
            ////--- Homework-6 Tasks ---
            // Task 1
            static void RotateArray(int[] arr, int n)
            {
                int[] rotated = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                    rotated[(i + n) % arr.Length] = arr[i];

                Console.Write("Rotated array: ");
                foreach (int num in rotated) Console.Write(num + " ");
                Console.WriteLine();
            }

            // Task 2
            static void BubbleSort(int[] arr)
            {
                int[] bubble = (int[])arr.Clone();
                for (int i = 0; i < bubble.Length - 1; i++)
                    for (int j = 0; j < bubble.Length - i - 1; j++)
                        if (bubble[j] > bubble[j + 1])
                        {
                            int temp = bubble[j];
                            bubble[j] = bubble[j + 1];
                            bubble[j + 1] = temp;
                        }

                Console.Write("Sorted array (Bubble Sort): ");
                foreach (int num in bubble) Console.Write(num + " ");
                Console.WriteLine();
            }

            // Task 3
            static void RemoveDuplicates(int[] arr)
            {
                Console.Write("Array without duplicates: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    bool duplicate = false;
                    for (int j = 0; j < i; j++)
                        if (arr[i] == arr[j]) { duplicate = true; break; }

                    if (!duplicate) Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }

            // Task 4
            static void MergeArrays(int[] arr1, int[] arr2)
            {
                int[] merged = new int[arr1.Length + arr2.Length];
                int m = 0, i1 = 0, i2 = 0;

                while (i1 < arr1.Length && i2 < arr2.Length)
                    merged[m++] = (arr1[i1] < arr2[i2]) ? arr1[i1++] : arr2[i2++];
                while (i1 < arr1.Length) merged[m++] = arr1[i1++];
                while (i2 < arr2.Length) merged[m++] = arr2[i2++];

                Console.Write("Merged array: ");
                foreach (int num in merged) Console.Write(num + " ");
                Console.WriteLine();
            }

            // Task 5 
            static void InsertElement(int[] arr, int pos, int value)
            {
                int[] newArr = new int[arr.Length + 1];
                for (int i = 0, j = 0; i < newArr.Length; i++)
                    newArr[i] = (i == pos) ? value : arr[j++];

                Console.Write("Array after insertion: ");
                foreach (int num in newArr) Console.Write(num + " ");
                Console.WriteLine();
            }

            // Task 6 
            static void DeleteElement(int[] arr, int del)
            {
                int[] delArr = new int[arr.Length - 1];
                int idx = 0;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] != del) delArr[idx++] = arr[i];

                Console.Write("Array after deletion: ");
                for (int i = 0; i < idx; i++) Console.Write(delArr[i] + " ");
                Console.WriteLine();
            }

            // Task 7 
            static void PairsWithSum(int[] arr, int target)
            {
                Console.WriteLine("Pairs with sum " + target + ":");
                for (int i = 0; i < arr.Length; i++)
                    for (int j = i + 1; j < arr.Length; j++)
                        if (arr[i] + arr[j] == target)
                            Console.WriteLine(arr[i] + ", " + arr[j]);
            }

            // Task 8 
            static void IsPalindrome(int[] arr)
            {
                bool palindrome = true;
                for (int i = 0; i < arr.Length / 2; i++)
                    if (arr[i] != arr[arr.Length - i - 1]) { palindrome = false; break; }

                Console.WriteLine("Palindrome: " + palindrome);
            }

            // Task 9 
            static void MissingNumber(int[] miss)
            {
                int k = miss.Length + 1;
                int expectedSum = k * (k + 1) / 2;
                int actualSum = 0;
                foreach (int num in miss) actualSum += num;

                Console.WriteLine("Missing Number: " + (expectedSum - actualSum));
            }

            // Task 10
            static void MostConsecutiveDuplicates(int[] arr)
            {
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
                Console.WriteLine(element + " appears " + maxCount + " times in a row");
            }
        static void Main(string[] args)
        {
            int[] arr = { 10, 5, 1, 15, 7, 50, 9 };

            RotateArray(arr, 2);
            BubbleSort(arr);
            RemoveDuplicates(arr);

            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4, 6 };
            MergeArrays(arr1, arr2);

            InsertElement(arr, 3, 10);
            DeleteElement(arr, 5);
            PairsWithSum(arr, 8);
            IsPalindrome(arr);

            int[] miss = { 1, 2, 4, 5 }; // Missing 3
            MissingNumber(miss);

            MostConsecutiveDuplicates(arr);
        }
    }
    }

