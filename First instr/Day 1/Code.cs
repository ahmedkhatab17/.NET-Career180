// See https://aka.ms/new-console-template for more information

using System;
using System.Text;
class Program
{
    static void Main()
    {
        Add(5, 6);
        var username = Console.ReadLine();

        Console.WriteLine(username);
        string name = null;
        string displayName = name ?? "Guest";
        Console.WriteLine(displayName);  // Output: Guest

        string namee = null;
        namee ??= "Guest";
        Console.WriteLine(name);  // Output: Guest

        Func<int, int, int, int> add = (a, b, c) => a + b + c;
        Console.WriteLine(add(5, 3, 5));  // Output: 8


        int s = 1;
        int d = 2;
        bool x = false;
        if (s == d || s != d)
        {
            Console.WriteLine("In If");
        }
        else if (s > d)
        {
            Console.WriteLine("In Else");
        }
        else if (s < d) {
            if (s != d)
            {

            }
            else if (true)
            {
                return;
            }
        }

        AA aA = new AA();
        aA.day = 2;
        switch (aA.day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }


        var result = ((s == d) || (s != d)) ? "Success" : "Failed";

        Console.WriteLine(result);



        if (!x)
        {
            Console.WriteLine("In If");
        }

        int a = 5 << 1; //0000 0101   0000 0111
        int y = a++;
        Console.WriteLine("a1 = " + a);
        Console.WriteLine("y1 = " + y);

        y = a;
        Console.WriteLine("a = " + a);
        Console.WriteLine("y = " + y);
         
        /*
        string text = "This is a \\    string\t with a newline.\nNext line\".";
        Console.WriteLine(text);

        // Output:
        // This is a string with a newline.
        // Next line.
        string path = """
C:\Users\Name\Documents\file.txt
""";
        Console.WriteLine(path); // Output: C:\Users\Name\Documents\file.txt


        string rawString = """
    This is a raw string.
    It preserves line breaks and special characters like "quotes".
    It preserves line breaks and special characters like "quotes".
    It preserves line breaks and special characters like "quotes".
    It preserves line breaks and special characters like "quotes".
    It preserves line breaks and special characters like "quotes".
    It preserves line breaks and special characters like "quotes".
    It preserves line breaks and special characters like "quotes".
    """;
        Console.WriteLine(rawString);


        string aa = "hi ahmed " +
            "hhfidhfidhi" +
            "kdhfkhdkhfk" +
            "dnvkdfnvjdfnkvj" +
            "kfngjknjkgfkj";


        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");

        sb.Append(", ");
        sb.Append("World!");
        Console.WriteLine(sb.ToString()); // Output: Hello, World!


        string str1 = "apple";
        string str2 = "banana";
        int comparison = string.Compare(str1, str2);
        Console.WriteLine(comparison); // Output: -1 (because "apple" comes before "banana")

        string str3 = "a12pple";
        string str4 = "a127890";
        int comparison2 = string.Compare(str3, str4);
        Console.WriteLine(comparison2); // Output: -1 (because "apple" comes before "banana")


        var serial = "NC101";
        Console.WriteLine(serial.Length);
        var serialNumber = serial.Substring(2);
        Console.WriteLine(serialNumber);
        var nexSerial = Convert.ToInt32(serialNumber);
        nexSerial += 1;
        Console.WriteLine(nexSerial);

        string sentence = "Hello, World!";

        //string part = sentence.Substring(1, 5); // From index 0, length 5
        //Console.WriteLine(part); // Output: Hello

        int index = sentence.IndexOf("o");
        Console.WriteLine(index); // Output: 7

        int age = 25;
        string name = "John";
        string formatted = string.Format("My name is {0} and I am {1} years old.", name, age);
        sentence = $"My name is {name} and I am {age} years old.";

        Console.WriteLine(formatted); // Output: My name is John and I am 25 years old.

        //string text = "apple banana orange ppppp,...";
        var fruits = text.Split(' ');
        fruits[0] = "apple";
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        // Declaration of variables
        int number1 = 10;
        int number2 = 20;
        int sum = number1 + number2;

        // Displaying output
        Console.WriteLine("The sum of " + number1 + " and " + number2 + " is: " + sum);
    
        */
    }


    public static void Add(int a, int b)
    {
        var sum = a + b;
        Console.WriteLine("sum = " + sum);
    }
}

class AA
{
   public int day = 1;
}

