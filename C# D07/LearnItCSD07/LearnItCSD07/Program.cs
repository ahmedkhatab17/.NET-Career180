namespace LearnItCSD07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum can carry many values
            ////Gender g1 = Gender.Female;
            ////Console.WriteLine(g1);
            ////g1 = (Gender)1;
            ////Console.WriteLine(g1);

            ////DayName d1 = DayName.Saturday;
            ////Console.WriteLine(d1);

            //DayName d2 = DayName.Friday | DayName.Tuesday;
            //Console.WriteLine(d2);

            ////Position p1 = Position.DBA | Position.Developer;
            //Position p1 = Position.DBA ^ Position.Developer;
            //Console.WriteLine(p1);
            //p1 ^= Position.DBA;
            //Console.WriteLine(p1);

            //Position p2=Position.DBA ^ Position.Developer^Position.secretary;
            //Console.WriteLine(p2);

            ////revoke DBA from mohamed  p1
            #endregion

            #region Interface -> like an abstract class
            /////c++ support multiple inheritance
            /////c# supports multi level inheritance
            /////issue , i need data from multiple DT's
            /////
            /////interface:
            /////reference Dt
            /////4th Dt written inside namespace
            /////is protocol between classes
            /////
            /////if class needs this interface, it will implement ALL Data inside that interface
            /////syntax
            /////inside ns{
            /////interface IMathService  
            /////{
            ///////method headers only without access modifiers
            ///////auto property without access modifiers 
            ///////because they always inherited/implemented as public
            /////}
            /////interface IEmployeeService
            /////
            /////class/struct can implement/inherit multiple interfaces
            /////

            ////CompanyService c1=new CompanyService();
            //////IMyInterface1 interface1 = new IMyInterface1();
            ////IMyInterface1 interface1;
            ////interface1=new CompanyService();


            //Draft o1= new Draft();

            //IMyInterface1 interface1 = o1;
            //IMyInterface2 interface2 = o1;
            //interface1.SignIn();
            //interface2.SignIn();

            //((IMyInterface1)o1).SignIn();
            #endregion

            #region Exception Handling
            ////Try catch is the worst exception handling Ever
            ////use try catch as last defensive wall
            ////use try catch if there is no way except it [Connect to DB] con open     RuntimeError    con close
            //int age;
            //try
            //{
            //    Console.WriteLine("Enter Age");
            //    age = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"age={age}");

            //    //int x = 3, y = 0, z;
            //    //z = x / y;

            //    //int[] arr = [1, 2, 3, 4, 5];
            //    //arr[10] = 100;

            //}
            //catch (FormatException ex) 
            //{
            //    Console.WriteLine($"Error Happened {ex.Message}");
            //}
            //catch (DivideByZeroException ex) 
            //{
            //    Console.WriteLine($"Error Happened {ex.Message}");
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error Happened {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error Happened {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("DONE!!!!!!!!!!");
            //}



            //Console.WriteLine("Enter Age");
            ////age = int.Parse(Console.ReadLine());
            //  int.TryParse(Console.ReadLine(), out int zz);
            //Console.WriteLine($"age={zz}");


            //int x = 3, y = 0, z;
            ////if(z!=0)
            //z = x / y;


            //int[] arr = [1, 2, 3, 4, 5];
            //int index = 10;
            ////if index<arr.Length
            //arr[index] = 100;
            #endregion

            #region One Employee
            //Employee e1 = new Employee();
            ////REMEMBER
            //e1.Dept=new Department();
            //e1.HD=new HireDate();
            ////
            //Console.WriteLine("enter id");
            //e1.Id=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter name");
            //e1.Name=Console.ReadLine();
            //Console.WriteLine("enter age");
            //e1.Age=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter salary");
            //e1.Salary=decimal.Parse(Console.ReadLine());
            //Console.WriteLine("enter gender");
            //e1.Gen=(Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            //Console.WriteLine("enter hire year");
            //e1.HD.Year = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter hire month");
            //e1.HD.Month = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter hire day");
            //e1.HD.Day = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter dept id");
            //e1.Dept.DeptId = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter dept name");
            //e1.Dept.DeptName = Console.ReadLine();
            //Console.WriteLine("enter desc");
            //e1.Dept.Description = Console.ReadLine();

            //Console.WriteLine(e1);
            #endregion

            #region Array of 3 employees
            //Employee[] employees = new Employee[3];

            ////employees[0] = new Employee();
            ////employees[1] = new Employee();
            ////employees[2] = new Employee();

            //for (int i = 0; i < employees.Length; i++) 
            //{
            //    //
            //    employees[i] = new Employee();
            //    employees[i].Dept = new Department();
            //    employees[i].HD = new HireDate();
            //    //
            //    Console.WriteLine("enter id");
            //    employees[i].Id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter name");
            //    employees[i].Name = Console.ReadLine();
            //    Console.WriteLine("enter age");
            //    employees[i].Age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter salary");
            //    employees[i].Salary = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("enter gender");
            //    employees[i].Gen = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            //    Console.WriteLine("enter hire year");
            //    employees[i].HD.Year = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter hire month");
            //    employees[i].HD.Month = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter hire day");
            //    employees[i].HD.Day = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter dept id");
            //    employees[i].Dept.DeptId = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter dept name");
            //    employees[i].Dept.DeptName = Console.ReadLine();
            //    Console.WriteLine("enter desc");
            //    employees[i].Dept.Description = Console.ReadLine();
            //}

            //for (int i = 0; i < employees.Length; i++) 
            //{
            //    Console.WriteLine(employees[i]);
            //}
            #endregion

            #region REMEMBER Array Default Values [anonymous object]
            //int[] nums = new int[] { 1, 2, 3, 4, 5 };
            //Employee[] employees = new Employee[] 
            //{
            //    new Employee{Id=1,Name="Sara",Age=27,Salary=10234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=2,Name="Ali",Age=30,Salary=9234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate(3,3,2003) },
            //    new Employee{Id=3,Name="Eman",Age=29,Salary=8234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate(2,2,2002) },
            //    new Employee{Id=4,Name="Osama",Age=28,Salary=7234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate(4,6,2007) },
            //    new Employee{Id=5,Name="Alaa",Age=27,Salary=6234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate(1,10,2020) },
            //    new Employee{Id=6,Name="Marwan",Age=26,Salary=5234,Gen=Gender.Male,Dept=new Department(80,"UI","UI"),HD=new HireDate(22,4,2015) },
            //    new Employee{Id=7,Name="Zainab",Age=25,Salary=4234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=8,Name="Ahmed",Age=24,Salary=3234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=9,Name="Aya",Age=23,Salary=2234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=10,Name="Tamer",Age=22,Salary=1234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate() },
            //}; 
            #endregion

            #region Sort Array of built in DT
            int[] arr = [1, 22, 44, -1, -22, -100, 5, 77, 6, 5, 4, 3];
            string[] strArr = ["Zainab", "Sara", "Saeed", "Ziad", "Osama", "alaa", "Aalaa"];
            Array.Sort(arr);
            Array.Sort(strArr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine(strArr[i]);
            //}

            ////foreach
            #endregion

            #region Sort Array of User Defined DT
            //Employee[] employees = new Employee[]
            //{
            //    new Employee{Id=1,Name="Sara",Age=27,Salary=10234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=2,Name="Ali",Age=30,Salary=9234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate(3,3,2003) },
            //    new Employee{Id=3,Name="Eman",Age=29,Salary=8234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate(2,2,2002) },
            //    new Employee{Id=4,Name="Osama",Age=28,Salary=7234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate(4,6,2007) },
            //    new Employee{Id=5,Name="Alaa",Age=27,Salary=6234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate(1,10,2020) },
            //    new Employee{Id=6,Name="Marwan",Age=26,Salary=5234,Gen=Gender.Male,Dept=new Department(80,"UI","UI"),HD=new HireDate(22,4,2015) },
            //    new Employee{Id=7,Name="Zainab",Age=25,Salary=4234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=8,Name="Ahmed",Age=24,Salary=3234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=9,Name="Aya",Age=23,Salary=2234,Gen=Gender.Female,Dept=new Department(),HD=new HireDate() },
            //    new Employee{Id=10,Name="Tamer",Age=22,Salary=1234,Gen=Gender.Male,Dept=new Department(),HD=new HireDate() },
            //};

            //Array.Sort(employees);

            ////for (int i = 0; i < employees.Length; i++)
            ////{
            ////    Console.WriteLine(employees[i]);
            ////}
            #endregion

            #region Clone object
            //Department d1 = new Department();
            //Department d2= new Department(20,"UI","UI");
            //Console.WriteLine($"d1 identity {d1.GetHashCode()}");
            //Console.WriteLine($"d2 identity {d2.GetHashCode()}");

            ////d1 = d2; //assign REFERENCE
            //d1 =(Department) d2.Clone();

            //Console.WriteLine($"d1 identity {d1.GetHashCode()}");
            //Console.WriteLine($"d2 identity {d2.GetHashCode()}");


            ////int[] nums = [1, 2, 3, 4, 5];
            ////int[] nums2 = (int[]) nums.Clone();
            #endregion
        }
    }
}
