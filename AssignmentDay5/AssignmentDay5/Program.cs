
namespace AssignmentDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Start
            //Parent p1 = new Parent();

            //Child c1 = new Child();

            //Child c2 = new Child(1, 2, 3);

            #endregion

            #region Task 1,3 => Geoshape /rect/tri/square/circle
            Rect r1 = new Rect();
            Rect r2 = new Rect(1, 2);

            Square s1 = new Square();
            s1.Dim1 = 1;
            s1.Dim2 = 2;
            Console.WriteLine(s1.CArea());

            Circle circle = new Circle(7);
            circle.Dim1 = 1;
            circle.Dim2 = 2;
            Console.WriteLine(circle.CArea());


            //Rect r1 = new Rect(4, 5);
            //Console.WriteLine("Rectangle Area: " + r1.CArea());

            //Square s1 = new Square(4);
            //Console.WriteLine("Square Area: " + s1.CArea());

            //Tri t1 = new Tri(4, 5);
            //Console.WriteLine("Triangle Area: " + t1.CArea());

            //Circle c1 = new Circle(3);
            //Console.WriteLine("Circle Area: " + c1.CArea());
            #endregion

            #region Task2 => late / early (virtule - override)
            Base b1 = new Base();
            b1.Show();

            Derived d1 = new Derived();
            d1.Show();

            Base b2 = new Derived(1, 2, 3);
            b2.Show();

            Base b3 = new Derived2(1, 2, 3, 4);
            b3.Show();

            Derived d2 = new Derived2();
            d2.Show(); 


            #endregion



        }
    }
}
