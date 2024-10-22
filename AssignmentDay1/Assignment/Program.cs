using System;
using System.Data;
namespace Assignment
{
    internal class Program
    {
        #region Task 1 (Calc Birthdays)
        //static void Main(string[] args)
        //{
        //    int birthYear, birthMonth, birthDay;
        //    do
        //    {
        //        Console.Write("Please Enter your year (1980 - 2023): ");
        //        birthYear = int.Parse(Console.ReadLine());
        //    } while (birthYear < 1980 || birthYear > 2023);

        //    do
        //    {
        //        Console.Write("Please Enter your month (1 - 12): ");
        //        birthMonth = int.Parse(Console.ReadLine());
        //    } while (birthMonth < 1 || birthMonth > 12);

        //    int maxDays = getDays(birthMonth, birthYear);
        //    do
        //    {
        //        Console.Write($"Please Enter your day (1 - {maxDays}): ");
        //        birthDay = int.Parse(Console.ReadLine());
        //    } while (birthDay < 1 || birthDay > maxDays);

        //    CalculateAge(birthYear, birthMonth, birthDay);
        //}
        //static int getDays(int month, int year)
        //{
        //    switch (month)
        //    {
        //        case 2:
        //            return leapYear(year) ? 29 : 28;
        //        case 4:
        //        case 6:
        //        case 9:
        //        case 11:
        //            return 30;
        //        default:
        //            return 31;
        //    }
        //}
        //static bool leapYear(int year)
        //{
        //    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        //}
        //static void CalculateAge(int birthYear, int birthMonth, int birthDay)
        //{
        //    int ageYears = 2024 - birthYear;
        //    int ageMonths = 10 - birthMonth;
        //    int ageDays = 21 - birthDay;

        //    if (ageDays < 0)
        //    {
        //        ageMonths--;
        //        ageDays += getDays(10 - 1, 2024);
        //    }
        //    if (ageMonths < 0)
        //    {
        //        ageYears--;
        //        ageMonths += 12;
        //    }
        //    Console.WriteLine($"You're {ageYears} years, {ageMonths} months, and {ageDays} days old.");
        //}
        #endregion

        #region Task 2 (Calculator)
        //static void Main(string[] args)
        //{
        //    char continueChoice;

        //    do
        //    {
        //        Console.Write("Please enter the first number: ");
        //        double num1 = double.Parse(Console.ReadLine());

        //        Console.Write("Please enter the second number: ");
        //        double num2 = double.Parse(Console.ReadLine());

        //        Console.Write("Please enter the operator (+, -, *, /): ");
        //        char op = char.Parse(Console.ReadLine());

        //        double result = 0;

        //        if (op == '+')
        //        {
        //            result = num1 + num2;
        //        }
        //        else if (op == '-')
        //        {
        //            result = num1 - num2;
        //        }
        //        else if (op == '*')
        //        {
        //            result = num1 * num2;
        //        }
        //        else if (op == '/')
        //        {
        //            if (num2 != 0)
        //            {
        //                result = num1 / num2;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Error: Division by zero.");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /");
        //        }
        //        if (op == '+' || op == '-' || op == '*' || (op == '/' && num2 != 0))
        //        {
        //            Console.WriteLine($"Result: {result}");
        //        }
        //        Console.Write("Continue? (y/n): ");
        //        continueChoice = char.ToLower(char.Parse(Console.ReadLine()));
        //        Console.WriteLine();
        //    } while (continueChoice == 'y');
        //    Console.WriteLine("Program end. Have a great day!");

        #endregion

        #region 1D Array (1-Array min and max value)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the Array Length: ");
        //    int lenght = int.Parse(Console.ReadLine());

        //    int[] arr = new int[lenght];
        //    for (int i = 0; i<lenght; i++)
        //    {
        //        Console.WriteLine($"Enter Elemnt {i+1} : ");
        //        arr[i] = int.Parse(Console.ReadLine());    
        //    }
        //    int min = arr[0];
        //    int max = arr[0];
        //    for (int i = 1; i < lenght; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        else if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    Console.WriteLine($"Min Value: {min}");
        //    Console.WriteLine($"Max Value: {max}");
        //}
        #endregion

        #region (2-Array sort)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the Array Length: ");
        //    int lenght = int.Parse(Console.ReadLine());

        //    int[] arr = new int[lenght];
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        Console.WriteLine($"Enter Elemnt {i + 1} : ");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //    for (int i = 0; i < lenght - 1; i++)
        //    {
        //        for (int j = 0; j < lenght - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Sorted array: ");
        //    foreach (int num in arr)
        //    {
        //        Console.Write($"{num} ");
        //    }
        //}
        #endregion

        #region 3-search on array
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the Array Length: ");
        //    int lenght = int.Parse(Console.ReadLine());

        //    int[] arr = new int[lenght];
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        Console.WriteLine($"Enter Elemnt {i + 1} : ");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine("Enter the number to search for: ");
        //    int target= int.Parse(Console.ReadLine());

        //    int[] indices = Find(arr, target);

        //    if (indices.Length == 0)
        //    {
        //        Console.WriteLine($"The number {target} not found");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number {target} is in index of:");
        //        for (int i = 0; i < indices.Length; i++)
        //        {
        //            Console.Write($"{indices[i]} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static int[] Find(int[] arr, int target)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == target)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        return new int[0];
        //    }

        //    int[] indices = new int[count];
        //    int index = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == target)
        //        {
        //            indices[index] = i;
        //            index++;
        //        }
        //    }
        //    return indices;
        //}
        #endregion

        #region 2D Arrar (sum of rows)
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the number of rows: ");
        //    int rows = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter the number of columns: ");
        //    int columns = int.Parse(Console.ReadLine());

        //    int[,] array = new int[rows, columns];

        //    Console.WriteLine("Enter the elements of the array:");
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < columns; j++)
        //        {
        //            Console.Write($"Element [{i + 1}, {j + 1}]: ");
        //            array[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }
        //    Console.WriteLine("Sum of each row:");
        //    for (int i = 0; i < rows; i++)
        //    {
        //        int sum = 0;
        //        for (int j = 0; j < columns; j++)
        //        {
        //            sum += array[i, j];
        //        }
        //        Console.WriteLine($"Sum of row {i + 1}: {sum}");
        //    }
        //}
        #endregion


    }
}



