namespace AssignmentDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Read from the User the Coordinates for 2 point P1, P2
            //Console.WriteLine("Enter P1:");
            //Console.Write("P1 x: ");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("P1 y: ");
            //int y1 = int.Parse(Console.ReadLine());
            //Console.Write("P1 z: ");
            //int z1 = int.Parse(Console.ReadLine());

            //Point3D P1 = new Point3D(x1, y1, z1);

            //Console.WriteLine("Enter P2:");
            //Console.Write("P2 x: ");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("P2 y: ");
            //int y2 = int.Parse(Console.ReadLine());
            //Console.Write("P2 z: ");
            //int z2 = int.Parse(Console.ReadLine());

            //Point3D P2 = new Point3D(x2, y2, z2);

            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");
            #endregion

            #region Three Points Read and Write

            //Point3D[] points = new Point3D[3];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new Point3D();
            //    Console.WriteLine($"Enter X for point {i+1}");
            //    points[i].X = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter Y for point {i+1}");
            //    points[i].Y = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Enter Z for point {i+1}");
            //    points[i].Z = int.Parse(Console.ReadLine());
            //}

            //// Display the array of points
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion

            #region math program

            //int a = 10, b = 5;
            //Console.WriteLine($"Addition: {Math.Add(a, b)}");
            //Console.WriteLine($"Subtraction: {Math.Subtract(a, b)}");
            //Console.WriteLine($"Multiplication: {Math.Multiply(a, b)}");
            //Console.WriteLine($"Division: {Math.Divide(a, b)}");

            #endregion

            #region Duration program
            Duration d1 = new Duration(1, 10, 15);
            Duration d2 = new Duration(7800);
            Duration d3 = new Duration(666);

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());
            Console.WriteLine(d3.ToString());

            d3 = d1 + d2;
            Console.WriteLine(d3.ToString());

            d3 = d1 + 7800;
            Console.WriteLine(d3.ToString());

            d3 = 666 + d3;
            Console.WriteLine(d3.ToString());

            d3 = d1++;
            Console.WriteLine(d3.ToString());

            d3 = --d2;
            Console.WriteLine(d3.ToString());

            Console.WriteLine(d1 > d2);
            Console.WriteLine(d1 < d2);
            #endregion
        }
    }
}
