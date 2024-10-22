using System;  //use libraries directly exists in NS
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace DotNetFirstLook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Quick Revision
 //Console.WriteLine("Hello .NET");
 //int age = 22;
 ////strint interpolation Very Recommended
 //Console.WriteLine($"Your age is {age}");
 ////NOT RECOMMENDED ->memory overhead
 //Console.WriteLine("Your age is "+ age);
 //Console.WriteLine("-----------------------");
 //Console.WriteLine("please enter age");
 //age=int.Parse(Console.ReadLine());
 /////o/p 22
 //Console.WriteLine($"Your age is {age}");
 //float salary;
 //Console.WriteLine("Enter salary");
 //salary=float.Parse(Console.ReadLine());
 //string name;
 //name= Console.ReadLine();
 //Console.WriteLine($"your name is {name}");


 //array
            #endregion


            #region Struct
 ////store data about Employee 
 /////id
 /////name
 /////age
 /////salary

 /////use array ?nooooo
 /////struct: data type with my own definition
 /////

 //Student s1;   //s1 -> id|UA| name|UA| age|UA| salary|UA| 
 ////variable from student   24B
 ////s1 unassigned local variable
 //Student s2;

 //s1.id = 1;
 //s1.name="ali";
 //s1.age = 22;
 //s1.salary = 1234.56M;     //float,decimal,double[Default]

 //Console.WriteLine(s1.id);
 //Console.WriteLine(s1.name);
 //Console.WriteLine(s1.age);
 //Console.WriteLine(s1.salary);
 //Console.WriteLine(s1);


            #endregion

            #region Value Type

            #endregion

            #region C# Data type and keyword
 /////C# is strongly typed
 /////C# is Type safety

 //Int32 x = 10;

 //Single y = 22;

 //Double z = 1.2;

 //String str = "Ali";

 //Boolean flag=true;

 ////int float double bool





 //////int x = 10;
 //////float y = 20;
 //////double z = 30;

 //////1.2 ->double
 ////float x=1.2F;
 ////double y=1.1;
 ////decimal z=1.2M;

            #endregion

            #region Reference Type
 //int[] arr = [1, 2, 3, 4, 5];
 //int[] arr2 = [6, 7, 8, 9, 10];
 ////storing in heap
 //Console.WriteLine(arr.GetHashCode());
 //arr = arr2;
            #endregion

            #region null always goes with REFERENCE TYPE

            #endregion

            #region if Condition
 //bool flag = true;
 //int x = 1;
 //int y = 2;
 //int z = 3;
 //if (flag)
 //{

 //}
 //else
 //{

 //}
            #endregion

            #region for loop
 //for (int i = 0; i < 10; i++)
 //{
 //    Console.WriteLine(i);
 //}

 //for (int i = 0;i < 20; i++)
 //{
 //    for (int j = 0; j < 20; j++)
 //    {

 //    }
 //}
            #endregion

            #region switch   string,int,char
 //string month = "Jan";
 //switch (month)
 //{
 //    case "Jan":
 //        Console.WriteLine("1");
 //        break;

 //    case "feb":
 //    case "Feb":
 //        Console.WriteLine("2");
 //    break;

 //    default:
 //        break;

 //    case "Mar":
 //        Console.WriteLine("3");
 //        break;


 //}
            #endregion

            #region while ,do-while

            #endregion

            #region Array Definitions
 //array is a reference type
 //you must use new to allocate
            #endregion

            #region 1D Array
 //int[] arr; //reference of array of int //ZERO Bytes //NULL //NOTHING
 //arr = new int[5]; //5*sizeof(int)B   |0|0|0|0|0|
 ////new + array=allocation in memory + value initialization

 //for (int i = 0; i < arr.Length; i++)
 //{
 //    Console.WriteLine($"Enter # at index {i}");
 //    arr[i]=int.Parse( Console.ReadLine() );
 //}

 //for (int i = 0; i < arr.Length; i++)
 //{
 //    Console.WriteLine($"# at index {i} is {arr[i]}");
 //}

 ////default values for array declaration
 //int[] arr2 = new int[5] {1,2,3,4,5 };
 //int[] arr3 = new int[10] {1,2,3,4,5,1,2,3,4,5 };
 ////int[] arr4=new int[]; //Compile Error
 //int[] arr5=new int[] { 1,2,3,4,5}; 
 //int[] arr6 = [1, 2, 3, 4, 5];

            #endregion

            #region 2D array
 //int[,] arr; //null //zero B  //NOTHING  //reference
 ////arr=new int[rowSize,colSize];
 //arr = new int[3, 4];

 //int[,] arr; //null //reference  //ZERO B
 //arr = new int[3, 4];
 //for (int i = 0; i < arr.GetLength(0); i++)
 //{
 //    for (int j = 0; j < arr.GetLength(1); j++)
 //    {
 //        Console.WriteLine();
 //    }
 //}

 //int[,] arr2 = new int[3, 4] { { 1,1,1,1},{1,1,1,1 },{1,1,1,1 } };
 //int[,] arr3 = new int[,] { { 1,1,1,1},{1,1,1,1 },{1,1,1,1 } };
 //int[,] arr4 = { { 1,1,1,1},{1,1,1,1 },{1,1,1,1 } };
            #endregion

            #region Jagged array   [LESS Used]
 //int[][] arr;
 //arr = new int[4][];

 //arr[0] = new int[4] { 1, 1, 1, 1 };
 //arr[1] = new int[3] { 1, 1, 1 };
 //arr[2] = new int[2] { 1, 1 };
 //arr[3] = new int[1] { 1 };

 //int[][] arr2 = new int[3][]
 //{ new int[] {1 },new int[] {2,2 },new int[] {3,3,3 } };
            #endregion


 //Stopwatch s = new Stopwatch();

 //s.Start();
 ////for
 //s.Stop();
 //Console.WriteLine(s.Elapsed);

            #region Lab Assignments
 //            ///1,3,5,7,8,10,12     31days
 //            ///4,6,9,11           30 days
 //            ///2      28,29 leap year    2000,2004,2008,2020,2024


 //            ///while ->   do while

 //            ///1- Birthdate
 //            ///plz enter your year from 1980->2023
 //            2000
 /////plz enter your year from 1980->2023
 //1900
 /////plz enter your year from 1980->2023
 //200
 /////plz enter your month 1-12
 //22
 /////plz enter your month
 //23
 /////plz enter your month
 //4
 /////plz enter your day
 //31
 /////plz enter your day
 //32
 /////plz enter your day
 //32
 /////plz enter your day
 //29
 /////plz enter your day
 //28

 /////you're 22y  3 months and 5 days

 //int currentday = 16;
 //            int currentmonth = 10;
 //            int currentyear = 2024;

 //            int day, month, year;

 //            //2-magic box  3*3


 //            ///3- dynamic magic box based on input   not eveen nor 1

 //            //plz enter odd size
 //            2
 ////plz enter odd size
 //1
 ////plz enter odd size
 //44
 ////plz enter odd size
 //5
 //system("cls");  //clear screen



 //            ///3-Calculator
 //            ///plz enter #1
 //            //2
 //            //plz wnter #2
 //            //3
 //            //plz enter operator
 //            //*

 //            //2*3=6
 //            //Continue ??? y or n 
 //            //y Enter

 //            ///plz enter #1
 //            //5
 //            //plz wnter #2
 //            //10
 //            //plz enter operator
 //            //+

 //            //5+10=15
 //            //Continue ??? y or n 
 //            //n

 //            //program end


 ///Arrays of 10 places of integer int arr[10]
 ///Read ALL Data From user in Runtime
 //XXX int arr[15]={1,2,3,4,5,6,7,8,9,0};

 //1D Array
 //1-Array min  and max value  |7|3|5|6|8|-1|-11|33|99| no built in fn
 //2-Array sort    same array            |-11|-1|3|5|6||||||no built in fn
 //3-search on array and return index
 //| 1 | 2 | 3 | 4 | 1 | 5 | 6 | 2 | 1 | 9 | 10 |

//which number you want to search
            ///4
            //done at index 3



            //5-2D Array
            //array [3][4]
            //Sum of Rows

            //6-Bonus multiply 2 matrix
            //3*2    *  2*1  =  3*1


            //7- bonus 3*3     *    3*2   =  3*2



            #endregion

        }
    }
}
