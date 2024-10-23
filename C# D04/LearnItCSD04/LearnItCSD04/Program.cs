namespace LearnItCSD04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Employee with Setters & getters
            //Student s1= new Student();

            //Console.WriteLine("Enter id");
            //s1.SetId(int.Parse(Console.ReadLine()));
            ////
            ////s1.id=int.Parse(Console.ReadLine());
            ////Console.WriteLine(s1.id);
            ////Console.WriteLine(s1.GetId());
            ////
            //Console.WriteLine("Enter name");
            //s1.SetName(Console.ReadLine());
            //Console.WriteLine("Enter age");
            //s1.SetAge(int.Parse(Console.ReadLine())); 
            //Console.WriteLine("Enter grade");
            //s1.SetGrade(float.Parse(Console.ReadLine()));

            //Console.WriteLine(s1.Print());
            #endregion

            #region Student with Properties
            //Student s1= new Student();

            //s1.Id = 22;
            ////s1.SetId(22);

            //s1.Name = "Sara";
            //s1.Age = 22;
            //s1.SetGrade(3.2F);

            //Console.WriteLine(s1.Id);

            #endregion

            #region Create object via ....property initialization

            ////Student s1 = new Student();
            ////Student s1_1 = new();
            ////Student s2= new Student(1,"Sara",22,1.2F);
            ////Student s3 = new Student(_id:1,_name:"Sara",_age:22,_grade:1.1F);

            //////MVC  -> create object via property initializer
            ////Student s4 = new Student
            ////{ Id=1,Name="Ali",Age=22, Grade=3.3F};

            ////Console.WriteLine(s4.Print());


            //Person p1 = new Person { Id = 1 ,Name="ali" ,Age=22,Price=3333};
            //p1.Id = 1;
            #endregion

            #region OOR
            //Relations between data types with each others
            //Student  Department  Instructor  Employee
            //1-Composition -> very strong relatinship [tightly coupled]
            //2-Aggregation -> weak relationship [whole vs. one]
            //3-Association ->Very Weak Relationship [peer to peer]
            //4-Inheritance

            ///////////////////////////////////////////////
            ///1- Association
            //////A- Very Weak relationship [peer to peer]
            //////B- Teacher -> course
            //////C- temporarily relationship
            //////D- Representation in code
            ////////////create reference from class inside another class
            ///////class Teacher
            ///{
            /////subject s1;
            /////ctor{s1=null;}
            ///}
            //////class Subject
            ///{
            /////Teacher t1;
            /////
            ///}
            //////E- 0-0 ,1-1 ,1-m , m-m
            //////F- No Dependency
            //////////////////////////////////////////////////
            ///2- Aggreagtion
            //////A-  Weak relationship [whole vs. part]
            //////B- Student - Department
            //////C- temporarily relationship
            //////D- Representation in code
            ////////////create reference from class inside another class
            ///////class Student
            ///{
            /////Department d1;
            /////ctor{s=null;}
            ///}
            //////class Department
            ///{
            /////Student t1;
            /////
            ///}
            //////E- 0-0 ,1-1 ,1-m , m-m
            //////F- No Dependency
            /////////////////////////////////
            ///3-Composition
            ///A- Tightly coupled [has a]
            ///B- Permenant Relationship
            ///C- Room - Wall
            /// //////D- Representation in code
            ////////////create Object from class inside another class
            ///////class Room
            ///{
            /////wall w1=new wall();
            /////wall w2=new wall();
            /////wall w3=new wall();
            /////wall w4=new wall();
            /////
            ///}
            //////class Wall
            ///{
            ////
            /////
            ///}
            /////E- Total Dependency
            ///


            //Weak Relationship
            //SOLID

            //D -> Dependency inversion
            //=====> model of how to create
            ////////loosely coupled application

            //relation   vs inheritance
            #endregion

            #region Composition

            //Rectangle r2 = new Rectangle(1, 2, 3, 4);
            //o/p

            //Rectangle r1 = new Rectangle();
            //o/p
            //point def ctor ul
            //point def ctor lr
            //rect ctor

            //Line l2 = new Line(1, 2, 3, 4);
            //o/p


            //Line l1 = new Line();  //object from line
            //o/p
            //point def ctor start
            //point def ctor end
            //line def ctor
            #endregion

            #region Association /aggregation
            //Point p1=new Point(1, 2);
            //Point p2=new Point(3, 4);
            //Point p3=new Point(5, 6);


            //Triangle t1=new Triangle();
            //Triangle t2=new Triangle(p1,p2,p3);

            ////set relationship
            //t1.P1 = p1;
            //t1.P2 = p2;
            //t1.P3 = p3;

            ////print
            ////draw
            ////

            /////Remove relationship
            //t1.P1 = null;
            //t1.P2 = null;
            //t1.P3 = null;

            //t2.P1 = null;
            //t2.P2 = null;
            //t2.P3 = null;

            #endregion

            #region Association Error
            ////Point p1 = new Point(1, 2);
            ////Point p2 = new Point(3, 4);
            ////Point p3 = new Point(5, 6);

            //Triangle t3= new Triangle(1,2,3,4,5,6);
            ////Object reference not set to an instance of an object.
            #endregion

            #region Default & null
            //string str = default;
            //int[] arr=default;
            //int x = default;

            ////Console.WriteLine(str.Length);  //Runtime Error

            ////for (int i = 0; i < arr.Length; i++) 
            ////{
            ////    Console.WriteLine(arr[i]);
            ////}

            ////if (str != null)
            ////{
            ////    Console.WriteLine(str.Length);
            ////}

            //Console.WriteLine(str?.Length);
            //Console.WriteLine("-----------------");


            ////for (int i = 0;arr!=null && i < arr.Length; i++)
            //for (int i = 0;i<arr?.Length; i++) 
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("----------------------------");
            #endregion



            #region //pass reference type by value vs pass reference type by reference
            //int[] arr = [1, 2, 3, 4, 5];
            //Console.WriteLine($"Original arr {arr.GetHashCode()}");

            ////Utility.MultiplyArrayByTenV( arr );
            //Utility.MultiplyArrayByTenR(ref arr );

            //Console.WriteLine($"Original arr after return from fn{arr.GetHashCode()}");
            #endregion

            #region string  [intern pool]
            //string str = "this is a test";
            //string str2 = "this is a test";

            //Console.WriteLine($"str identity{str.GetHashCode()}");
            //Console.WriteLine($"str2 identity{str2.GetHashCode()}");
            //str2 += " Done";
            //string str3 = "this is a test Done";
            //Console.WriteLine($"str identity{str.GetHashCode()}");
            //Console.WriteLine($"str2 identity{str2.GetHashCode()}");
            //Console.WriteLine($"str3 identity{str3.GetHashCode()}");
            #endregion

            #region Lab Assignments
            ////IN ONE PROJECT
            ///create composition and aggregetion 
            ///over line rect circle tri   with point
            ///
            ///try fields + property with Employee Class id name age salary
            ///try auto property over student class id name age grade
            ///
            ///try in main create object via property initializer
            ///
            ///hackerRank
            ///leetcode
            #endregion

        }
    }
}
