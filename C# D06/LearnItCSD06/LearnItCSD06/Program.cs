using System.Numerics;
namespace LearnItCSD06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Virtual
            ///function that is important in overriding
            ///to make late binding
            ///reference from parent references object from child
            ///and call overridden method
            ///compiler will later at runtime retrieve
            ///copy of fn that related to object not that related to reference
            ///
            ///virtual function may / may not be overridden


            ///how to make virtual function MUST be overridden?
            ///if it became Abstract function
            ///
            /// Abstract function:virtual function MUST be overridden
            /// Abstract function : virtual fn header only without body
            /// Abstract function must appear in abstract class
            #endregion

            #region anonymous object
            ////new Rect(1, 2);
            //int[]arr=new int[10] { 1,2,3,4,5,6,7,8,9,0};
            //string[] strArr = ["aaa","ddd","vvv","rrr"];
            //Rect[] rectss = new Rect[2] { new Rect(1, 2), new Rect(3, 4) };
            #endregion

            #region Problem
            //Rect[] rects = new Rect[] { new Rect(1, 2), new Rect(2, 5) };
            //Square[] squares = new Square[3] {new Square(10), new Square(10), new Square(10) };
            //Tri[] triangles = [new Tri(3, 4), new Tri(5, 6)];
            //Console.WriteLine(GeoshapeUtility.SumOfAreas(rects,squares,triangles));
            #endregion

            #region Solution
            ////Geoshape g1 = new Rect(3, 4);
            ////Console.WriteLine(g1.CArea()); //12

            //Rect[] rects = new Rect[] { new Rect(1, 2), new Rect(2, 5) };
            //Square[] squares = new Square[3] { new Square(10), new Square(10), new Square(10) };
            //Tri[] triangles = [new Tri(3, 4), new Tri(5, 6)];
            //Circle[] circles = [new Circle(7)];
            //Geoshape[] geoshapes = 
            //    [
            //    rects[0],
            //    rects[1],
            //    squares[0],
            //    squares[1],
            //    squares[2],
            //    triangles[0],
            //    triangles[1],
            //    circles[0],
            //    ];

            //Console.WriteLine(GeoshapeUtility.SumOfAreasV2(geoshapes));
            #endregion

            #region System.Object
            ////All Data types in c# [built in or user defined]
            ////inherit from Parent DT called [class object]

            ////class object : parent DT For ALL Dt's in C# [built in or user defined]
            /////WHY?
            /////It carries common features for All DT needed
            /////class Object
            /////public virtual string ToString(){}
            /////public virtual bool Equals(object o1){}
            /////public virtual int GetHashCode(){}
            /////public static bool Equals(object left,object right){}
            /////public static bool ReferenceEquals(object left,object right){}
            /////public Type GetType(){}

            ////Rect r1 = new Rect(2, 3);
            ////Console.WriteLine(r1.ToString());
            ////Console.WriteLine(r1);

            ////int x = 22;
            ////Console.WriteLine(x);
            ////Console.WriteLine(x.ToString());

            //object o1=new Rect(2, 3);
            ////Console.WriteLine(o1.ToString());
            //Console.WriteLine(o1.GetType().Name); //ns.Rect  //Rect
            #endregion

            #region value type with System.Object class
            //int x = 22;
            //float y = 1.2f;
            //bool flag = true;

            ////boxing [transfer value from stack to heap]
            ////boxing -> safe casting
            //object o1=x;
            //Console.WriteLine(o1.GetType()) ;

            ////unboxing -> unsafe casting
            //int z = (int)o1;
            //Console.WriteLine(z);
            #endregion

            #region C# is auto memory allocation/deallocation
            /////-> CLR -> Garbage collector
            //Geoshape g1 = new Rect(3, 4);    
            //g1 = new Square(10);
            ////new Rect(3, 4);  ---> GC

            ////c,c++ -> manual memory allocation
            /////allocate 
            /////Remember to deallocate
            /////[dangerous memory leackage]
            /////geoshape* g1=new Rect(3,4);
            /////delete  g1;
            /////g1=new Rect(5,6);
            ///
            //using (Rect r1=new Rect()) 
            //{
            //    Console.WriteLine(r1.CArea());
            //}
            #endregion

            #region Static class ,static ctor
            //static class : class each member inside it is static  

            /////static constructor 
            ///:constructor used to initialize static members
            ///-static ctor is called Once and only once per class called
            /// 
            ///how to write ststic constructor Explicitly
            ///1- same name of class starts with static
            ///2- has no return type even void
            ///3- has no overloads [only one parameterless static ctor]
            ///4- has no access modifier even public
            #endregion

            #region operator overloading
            /////operators can be overloaded
            /////when to overload operator ,it must be public and static
            /////= operator cannot be overloaded
            /////+= cannot be overloaded
            /////&&,|| cannot be overloaded
            /////
            /////+,-,* can be overloaded
            /////++,-- can be overloaded
            /////>,<.>=   == != can be overloaded
            /////casting operator can be overloaded + must specify implicit or explicit


            ////int x = 3, y = 4, z;
            ////z = x + y;  //compiler   int operator+(int left,int right){}
            ////Console.WriteLine(z);

            ////int operator+(int left, int right){ }
            ////float operator+(float left, float right){ }
            ////Complex operator+(Complex left, Complex right){ }


            //Complex c1 = new(3, 4);
            //Complex c2 = new(5, 6);
            //Complex c3 = new();

            ////c3=c1.Add(c2);
            ////c3 = c1 + c2; //Compiler ->Complex operator+(Complex left,Complex right){}

            ////c3 = c1 + 10;

            ////c3 = 10 + c1;

            ////c3 = ++c1;
            ////Console.WriteLine($"c1={c1}");  //4+5i
            ////Console.WriteLine($"c3={c3}");  //4+5i

            ////if (c1 > c2) 
            ////{
            ////    Console.WriteLine("Bigger");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("smaller");
            ////}

            ////casting
            //int real = c1;
            //Console.WriteLine(real); //3

            //string str =(string) c1;
            //Console.WriteLine(str); //3+4i
            #endregion

            #region Later
            //enum with many values
            //indexer property
            //SingleTon
            //Dependency injection Example
            #endregion

        }
    }
}
