using System.Numerics;
using System.Collections;
using System.Collections.Generic;

namespace LearnItCSD08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Check equality between 2 Reference Dt's
            //Point p1 = new Point { X = 3, Y = 4 };
            //Point p2 = new Point {X = 5, Y = 6};
            //Point p3 = new Point {X = 3, Y = 4};
            //Point p4 = p1;
            //Point p5=default;
            //Point3d p3d = new Point3d { X = 3, Y = 4, Z = 5 };
            ////Console.WriteLine($"p1 {p1}-> {p1.GetHashCode()}");
            ////Console.WriteLine($"p2 {p2}->{p2.GetHashCode()}");
            ////Console.WriteLine($"p3 {p3}->{p3.GetHashCode()}");
            ////Console.WriteLine($"p4 {p4}->{p4.GetHashCode()}");
            /////check equality [default behavior]
            /////==                     [Identity]
            /////system.Object
            /////virtual Equals         [Identity]
            /////static Equals          [Identity]
            /////static ReferenceEquals [Identity]

            ////if (p1==p4) 
            ////if (p1.Equals(p4)) 
            ////if (object.Equals(p1,p4))
            ////if (object.ReferenceEquals(p1,p4)) 
            //if (p1.Equals(p3d)) 
            //{
            //    Console.WriteLine("EQ");
            //}
            //else
            //{
            //    Console.WriteLine("NEQ");
            //}

            //object o1 = p3d;
            //Console.WriteLine(o1.GetType());
            #endregion

            #region Check equality between 2 ValueT Dt's
            /////check equality [default behavior]
            /////==                     Not Implemented , you must overload it
            /////system.Object
            /////virtual Equals         [values][state]  override to ensure performance 
            /////static Equals          [values][state]
            /////static ReferenceEquals NOT WORK PROPERLY
            #endregion

            #region Create Single Object From class  design patterns[SingleTon]
            ////NetworkCard c1= new NetworkCard();
            ////NetworkCard c2= new NetworkCard();
            ////NetworkCard c3= new NetworkCard();
            ////NetworkCard c4= new NetworkCard();
            ////Console.WriteLine(c1.GetHashCode());
            ////Console.WriteLine(c2.GetHashCode());
            ////Console.WriteLine(c3.GetHashCode());
            ////Console.WriteLine(c4.GetHashCode());

            ////NetworkCard c1= new NetworkCard();

            ////NetworkCard c1 = NetworkCard.CreateObject();
            ////NetworkCard c2 = NetworkCard.CreateObject();
            ////NetworkCard c3 = NetworkCard.CreateObject();
            ////Console.WriteLine(c1.GetHashCode());
            ////Console.WriteLine(c2.GetHashCode());
            ////Console.WriteLine(c3.GetHashCode());



            //WirelessCard Wcard1 = WirelessCard.Card;
            //WirelessCard Wcard2 = WirelessCard.Card;
            //WirelessCard Wcard3 = WirelessCard.Card;
            //WirelessCard Wcard4 = WirelessCard.Card;
            //WirelessCard Wcard5 = WirelessCard.Card;
            #endregion

            #region Generics
            ///////is there any way to write class once 
            ///////and can be container for any DT?  Yes
            ///////c++[template] => C# [Generics]
            ///////generics => container class
            ///////
            //////MyStack s1 = new MyStack(); //Compile Error


            //MyStack<int> s1= new MyStack<int>();
            ////MyStack<string> s2= new MyStack<string>();
            ////MyStack<Point> s3= new MyStack<Point>();
            ////s1.Push(44);
            ////s2.Push("Sara");


            ///////generic constrains
            /////

            ///what is valid to write with generic

            #endregion

            #region Array Big Issue
            ////Fixed size
            //int[] arr = [1, 2, 3, 4, 5];
            //string[] strArr = ["","","","",""];
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("==================");
            ////automatic iterator loop ascending till end
            /////foreach(DT Item in Collection)
            /////{
            /////      code here
            /////}
            //foreach (var value in arr) 
            //{
            //    Console.WriteLine(value);
            //}

            #endregion

            #region Non Generic Collection
            //ArrayList l1=new ArrayList(5);
            ////expandable
            //l1.Add(1);
            //l1.Add(2);
            //l1.Add(3);
            //l1.Add(4);
            //l1.Add(5);
            //Console.WriteLine(l1.Capacity);
            //l1.Add(6);
            //l1.Add("Reda");
            //l1.Add(new Point(3,4));

            //Console.WriteLine(l1.Capacity); //*2
            #endregion

            #region Generic Collections
            #region List
            //List<int> nums = new List<int>(10) { 1, 2, 3, 4, 5 };
            ////nums.Add(1);
            ////nums.Add(2);
            ////nums.Add(3);
            ////nums.Add(4);
            ////nums.Add(5);
            //nums.TrimExcess();
            //Console.WriteLine(nums.Capacity);
            //Console.WriteLine("---------------");
            //nums.AddRange(new int[] { 6, 7, 8, 9, 10 });
            ////
            //nums[0] = 1000;  //update
            //Console.WriteLine($"---->{nums[7]}"); //read
            ////nums[10] = 300; //insert Runtime ERROR
            //nums.Remove(1000);
            ////

            //for (int i = 0; i < nums.Count; i++) 
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //foreach (int item in nums) 
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region Dictionary
            // Dictionary<int,string> dic= new Dictionary<int,string>();
            // dic.Add(1, "Aya");
            // dic.Add(2, "Ali");
            // dic.Add(3, "Sara");
            // dic.Add(4, "Ahmed");
            // //dic.Add(4, "Osama");

            // //dic[1] = "Saeed"; //update
            // //Console.WriteLine(dic[2]); //get
            // dic[5] = "YTRTYTRRTYTRER"; //insert


            // ////if not exist Add
            // //dic.Add(5, "Osama");
            // /////if exists update 
            // //dic[5] = "Osama";

            //if(!dic.TryAdd(5, "Osama")) 
            // {
            //     dic[5] = "Osama";
            // }


            // foreach (KeyValuePair<int,string> item in dic)
            // {
            //     Console.WriteLine(item.Key +""+ item.Value);
            // }
            #endregion
            #endregion

            #region Important note
            //Dictionary<Point,string> keys = new Dictionary<Point,string>();

            //if two objects have different hashcode, that means they are different
            //if two objects have same hashcode ,that not means they are identical in ALL CASES 100%

            #endregion

            #region LAb Assignments
            //Try Regions from Lecture
            #endregion

        }

    }
}
