namespace LearnItCSD02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] arr;  //Zero Bytes have been allocated //NULL  //reference 
            //arr= new int[10];
            ////new +array=> allocation in heap + data initialization
            #endregion

            #region Struct
            /////value Type -> struct , enum
            /////Reference Type -> class
            /////
            //Student s1;  //24B //unassigned member fields
            //s1= new Student();
            ////new + struct=data fields initialization

            //Console.WriteLine(s1); //namepspace.structName
            //Console.WriteLine(s1.id);
            //Console.WriteLine(s1.name);
            //Console.WriteLine(s1.age);
            //Console.WriteLine(s1.grade);


            #endregion

            #region Array of Students
            //Student[] students; //ZeroB  //NULL
            //students = new Student[3];
            ////new + array=allocation +data initialization   3*24B
            //for (int i = 0; i < students.Length; i++) 
            //{
            //    Console.WriteLine("Enter Id");
            //    students[i].id=int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Name");
            //    students[i].name = Console.ReadLine();
            //    Console.WriteLine("Enter Age");
            //    students[i].age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Grade");
            //    students[i].grade=decimal.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < students.Length; i++) 
            //{
            //    Console.WriteLine(students[i].id);
            //    Console.WriteLine(students[i].name);
            //    Console.WriteLine(students[i].age);
            //    Console.WriteLine(students[i].grade);
            //}
            #endregion

            #region Enum Part 01
            ////create Dt represents restricted values
            ////enum is represented as numeric value
            //Gender g1;
            //g1 = Gender.Male;
            //Console.WriteLine(g1);

            //g1 = (Gender)333;
            //Console.WriteLine(g1);

            //DayName d1 = (DayName)78;
            //Console.WriteLine(d1);

            //Gender g2;
            //string tmp;
            //Console.WriteLine("Please enter Gender male or female");
            //tmp = Console.ReadLine();
            //if (tmp.ToLower() == "male")
            //{
            //    g2 = Gender.Male;
            //}
            //else 
            //{
            //    g2 = Gender.Female;
            //}
            //Console.WriteLine($"=====>{g2}");
            /////
            ////g2=Enum.Parse(typeof(Gender), Console.ReadLine());
            #endregion

            #region access modifiers inside namespace
            ///inside namespace we can create
            ///1-class
            ///2-struct
            ///3-enum
            ///4-interface
            ///5-delegate
            ///
            ///inside namespace , there are 2 access modifiers
            ///1- public [RECOMMENDED]  : this DT can be accessed inside project[assembly] created inside and outside it 
            ///2- internal[default] : this DT can be accessed inside project[assembly] created inside only 
            #endregion

            #region casting between numeric DT    _[discard]
            /////casting:->value can be converted from DT to another one
            /////casting can be done implicitly or explicitly
            /////implicit cast:Compiler will do casting itself
            /////explicit cast:developer will do casting himself

            //int x = 22;// int.MaxValue;
            //double y = 33_333_333_333;

            //////safe casting
            //////implicit casting
            ////y = x;
            //////explicit casting
            ////y = (double)x;

            //////unsafe casting
            //////implicit casting
            ////x = y;

            //////unsafe casting leads to
            //////explicit casting
            ////x =(int)y;

            //checked
            //{
            //    x = (int)y;
            //    unchecked
            //    {

            //    }

            //}



            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"y={y}");

            #endregion

            #region casting between value Type and system.Object
            #endregion

            #region implicit type cast [var] not dt  => Linq
            ////C# is strongly typed 
            ////C# is typed safety
            //int x = 10;

            //var y = 1.2M;

            //var str = "Ali";

            //var s1 = new Student();

            //var keyValues= new Dictionary<Student,string>();

            //var reda=11;  //compile error
            #endregion

            #region dynamic    => asp.net core mvc [ViewBag]   //interoperability this code can be accessed anywhere
            //dynamic x = 10;
            //Console.WriteLine(x.GetType());
            ////keyword its Dt will be defined at runtime
            //x = "Sara";
            //Console.WriteLine(x.Length);
            //Console.WriteLine(x.GetType());
            //x = 1.2;
            //Console.WriteLine(x.GetType());
            #endregion

            #region Nullable Value type
            //////value type cannot be null
            //////int x=null;

            //////DB  sql Server
            ///////Employee
            ///////intPK  vcNN   intN    decimalN     
            ///////id     name   age    salary
            ///////1      ali    22     null
            ///////2      sara   null   null
            ///////3      osama  null   null
            ///////

            ///////ORM [EF]
            ///////stuct Employee{
            ///////int id
            ///////string name
            ///////int age
            ///////decimal salary
            ///////}
            ///////Employee e1=new Employee(3,"Osama",null,null);
            ///////
            /////

            //int? x=null; //4B   + feature allow null keyword
            ////bool x.HasValue
            ////x.Value  get value
            ////Console.WriteLine(x.Value);
            //if (x.HasValue)
            //{ Console.WriteLine(x); }
            //else { Console.WriteLine("EMPTY"); }

            //double y;


            #endregion

            #region default & null propagation operator
            //string str = default;  //null
            //int? x = default;   //0
            //int[] arr = default; //null

            //////unprotective/undefensive code
            ////Console.WriteLine(str.Length);
            //////Object reference not set to an instance of an object.

            ////if(str !=null )
            ////{
            ////    Console.WriteLine(str.Length);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("EMPTY!!!!");
            ////}


            //Console.WriteLine(str?.Length ?? -1);

            ////left??right

            ////for (int i = 0; arr!=null && i < arr.Length; i++)
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            ////Console.WriteLine(x.Value);
            #endregion

            #region non nullable reference type start from .net 6

            ///////till .net 5
            ///////reference type can carry null as a normal way
            ////string str = null;

            //string str = null;
            ///////from .net 6
            ///////reference type is non nullabe [as default]
            ///////if non nullabale ref type assigned by null 
            ///////WARNING NOT COMPILE ERROR
            ////string str=null;
            ////int[] arr=null;
            ////Console.WriteLine(str);

            //////i wanna create reference type carries null
            ////string? str2= null;
            ////Console.WriteLine(str2);

            ////string name = Console.ReadLine();
            #endregion

            #region OOP -> Encapsulation
            //->class -> reference Type
            //Employee e1; //reference of employee   //ZEROOOB   ///null
            //e1=new Employee();
            ///object/instance from employee in heap 24B
            ///new +class -> allocation in heap + data fields initialization

            /////OOP Violation -> encapsulation
            //e1.id = 1;
            //e1.name = "string.Empty";
            //e1.age = 22;
            //e1.salary = 1234;
            //Console.WriteLine(e1.id);
            //Console.WriteLine(e1.name);
            //Console.WriteLine(e1.age);
            //Console.WriteLine(e1.salary);

            #endregion

            #region Encapsulation V02
            //Employee e1; //reference of employee   //ZEROOOB   ///null
            //e1 = new Employee();  //e1  id|1| name|| age|| salary|| 

            //Employee e2=new Employee(); //e2  id|22| name|| age|| salary||

            ////e1.SetId(1);
            ////e2.SetId(22);

            ////Console.WriteLine(e1.GetId());
            ////Console.WriteLine(e2.GetId());

            //e1.SetId(1);
            //e1.SetName("Sara");
            //e1.SetAge(22);
            //e1.SetSalary(1223);
            //Console.WriteLine(e1.PrintV2());
            #endregion

            #region One Employee Read and Write [class]
            //Employee e1;  //Reference ///ZERO B   //null
            //e1= new Employee();  //instance from employee
            //new + class => allocation + initialization

            //Console.WriteLine("Enter id");
            //e1.SetId(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter name");
            //e1.SetName(Console.ReadLine());
            //Console.WriteLine("Enter age");
            //e1.SetAge(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter salary");
            //e1.SetSalary(decimal.Parse(Console.ReadLine()));

            //Console.WriteLine(e1.PrintV2());
            #endregion

            #region Array of 3 employees Read and write
            //Employee[] employees; //reference  //ZERO B   //null
            //employees = new Employee[3];
            ////new +array=allocation +initialization

            ////employees[0] = new Employee();
            ////employees[1] = new Employee();
            ////employees[2] = new Employee();
            //////new + class=allocation +iniialization



            //for (int i = 0; i < employees.Length; i++)
            //{
            //    // is must with class   -> useless with struct
            //    employees[i] = new Employee();
            //    //
            //    Console.WriteLine("Enter id");
            //    employees[i].SetId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter name");
            //    employees[i].SetName(Console.ReadLine());
            //    Console.WriteLine("Enter age");
            //    employees[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter salary");
            //    employees[i].SetSalary(decimal.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].PrintV2());
            //}

            /////FAMOUS RUNTIME ERROR
            /////Object reference not set to an instance of an object.
            #endregion

            #region array of 10 employees and choose index to enter
            //////employees |#|#|A|#|#|S|#|#|#|#|
            /////choose index 0->9
            /////2
            /////enter id 1
            /////enter name ali
            /////enter age 22
            /////enter salary 1234
            /////continue y or n ? y
            /////choose index
            /////5
            /////enter id 2
            /////enter name Sara
            /////enter age 23
            /////enter salary 4234
            /////continue y or n ? n
            /////print Sara and ali ONLY

            //Employee[] employees = new Employee[10];
            //int index;
            //string flag;
            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Choose index 0->9");
            //        index = int.Parse(Console.ReadLine());
            //    } while (index < 0 || index > 9);

            //    employees[index] = new Employee();
            //    //
            //    Console.WriteLine("Enter id");
            //    employees[index].SetId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter name");
            //    employees[index].SetName(Console.ReadLine());
            //    do
            //    {
            //        Console.WriteLine("Enter age");
            //        employees[index].SetAge(int.Parse(Console.ReadLine()));
            //    }
            //    while (employees[index].GetAge()<18 || employees[index].GetAge() > 60);

            //    Console.WriteLine("Enter salary");
            //    employees[index].SetSalary(decimal.Parse(Console.ReadLine()));

            //    Console.WriteLine("Continue , yes or no");
            //    flag = Console.ReadLine();

            //}
            //while (flag.ToLower() == "yes");

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    //print enetered employees ONLY 
            //}

            #endregion

            #region Complex
            //Complex c1=new Complex();
            //Complex c2=new Complex();
            //Complex c3=new Complex();

            //c1.SetReal(3);
            //c1.SetImg(4);

            //c2.SetReal(5);
            //c2.SetImg(6);

            //Console.WriteLine(c1.Print());
            //Console.WriteLine(c2.Print());

            ////c3 = c1.Add(c1, c2);
            //c3 = c1.Add(c2);


            //Console.WriteLine(c3.Print());
            #endregion

            #region Lab Assignments
            ///constructor
            ///static
            ///stack
            ///operator overloading
            ///property
            ///singleTon->
            ///
            ///1- Array of 10 employees and choose index
            ///then print entered data ONLY
            
            ///2-complex class , fields,S&G,P
            ///print   real +  img i
            ///

            ////r   i
            ///3    4   3+4i
            ///3   -4   3-4i
            ///3    1   3+i
            ///3   -1   3-i
            ///0    1   i
            ///0   -1   -i
            ///0   -4   -4i
            ///0   0    0
            ///10  0    10
            #endregion
        }
    }
}
