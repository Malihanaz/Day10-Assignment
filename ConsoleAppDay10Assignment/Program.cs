using System;

class SortingAndSearching
{
    static void Main()
    {
        // Example usage:
        int[] randomArray = GenerateRandomArray(10);
        Console.WriteLine("Original Array:");
        PrintArray(randomArray);

        BubbleSort(randomArray);
        Console.WriteLine("\nSorted Array using Bubble Sort:");
        PrintArray(randomArray);

        int searchValue = 5;
        int index = BinarySearch(randomArray, searchValue);
        if (index != -1)
            Console.WriteLine($"\n{searchValue} found at index {index}.");
        else
            Console.WriteLine($"\n{searchValue} not found in the array.");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] > target)
                left = mid + 1;

            else
                right = mid - 1;
        }

        return -1; // If the element is not present in the array
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100); // Adjust the range as needed
        }

        return array;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
