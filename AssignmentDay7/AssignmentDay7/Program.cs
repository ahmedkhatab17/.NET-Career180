using System.Globalization;

namespace AssignmentDay7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region class Point3D:IComparable ,ICloneable ,Sort
            Point3D[] points = new Point3D[]
                {
                new Point3D(3, 5, 7),
                new Point3D(1, 2, 3),
                new Point3D(3, 1, 2),
                new Point3D(2, 2, 2),
                new Point3D(1, 5, 6)
                };

            Array.Sort(points);

            Console.WriteLine("Sorted Points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }
            #endregion


            #region Read Data
            Employee e1 =new Employee();

            Console.WriteLine("Enter ID:");
            e1.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            e1.Name = Console.ReadLine();

            Console.WriteLine("Enter Gender (M/F):");
            e1.Gen = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

            Console.WriteLine("enter salary");
            e1.Salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter hire year");
            e1.HD.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter hire month");
            e1.HD.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter hire day");
            e1.HD.Day = int.Parse(Console.ReadLine());

            Console.WriteLine("enter desc");
            e1.State = (State)Enum.Parse(typeof(State), Console.ReadLine(), true);

            #endregion

            #region output
            Console.WriteLine("\nEmployee Information:");
            Console.WriteLine(e1);
            #endregion


            #region arr of 3 emp
            Employee[] employees = new Employee[3];

            employees[0] = new Employee();
            employees[1] = new Employee();
            employees[2] = new Employee();
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                Console.WriteLine("Enter ID:");
                e1.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name:");
                e1.Name = Console.ReadLine();

                Console.WriteLine("Enter Gender (M/F):");
                e1.Gen = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

                Console.WriteLine("enter salary");
                e1.Salary = decimal.Parse(Console.ReadLine());

                Console.WriteLine("enter hire year");
                e1.HD.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("enter hire month");
                e1.HD.Month = int.Parse(Console.ReadLine());
                Console.WriteLine("enter hire day");
                e1.HD.Day = int.Parse(Console.ReadLine());

                Console.WriteLine("enter desc");
                e1.State = (State)Enum.Parse(typeof(State), Console.ReadLine(), true);

            }

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }



            #endregion



        }



    }
}
