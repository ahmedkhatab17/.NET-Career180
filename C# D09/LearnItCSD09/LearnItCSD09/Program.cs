namespace LearnItCSD09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region override Hash code for objects equality
            //if 2 object have different hashcode it means they are NOT EQUALS
            //if 2 object have same hashcode it is not mean by necessary they are EQUALS

            //Identity Hashing for object??? CLR
            //may 2 different object CLR generates same Identity 1%

            ///in System.Object
            ///there is feature for overriding getHashCode for that reason
            ///for you to ensure identity cannot be crash with 2 different object

            ///necessary with dictionary,hashtable,hashset
            ///Dictionary<Employee,string> obj=new.....;
            ///

            ///when override gethashcode , you should override Equals

            //check equality
            //1- check on Equals
            //2- check on gethashCode
            #endregion

            #region Collections base  [IEnumerable]
            //IEnumerable<int> o1 = new int[5];
            //IEnumerable<string> o2 = new List<string>();
            ////Why -> in Linq   
            #endregion

            #region Generic with Function
            //int x = 3, y = 5;
            //Trial1.Swap(ref x, ref y);
            //string str1 = "", str2 = " ";
            //Trial1.Swap<string>(ref str1, ref str2);

            //Trial2<int>.Swap(ref x, ref y);
            #endregion

            #region Repository
            var employees=Repository.Employees;

            //foreach (var employee in employees) 
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region Filtration V1
            //var filteredEmps=Filtration.FilterPerDeptId(employees);
            //filteredEmps=Filtration.FilterPerSalary(employees);
            //filteredEmps=Filtration.FilterPerAge(employees);
            ////
            //filteredEmps = Filtration.FilterPerAny(employees);
            //foreach (var item in filteredEmps) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Solution
            ///we think of way to pass collection of employees
            ///and also pass filter methodology
            ///filteredEmps=filtration.PerABC(employees,How To filter);
            ///filteredEmps=filtration.PerABC(employees,perSalary);
            ///filteredEmps=filtration.PerABC(employees,perDeptId);
            #endregion

            #region Delegate
            ///pointer to function
            ///variable can carry/point function
            ///delegate is the 5th dT written inside namespace
            ///delegate is reference T
            ///

            ///when you declare delegate,
            ///you must declare it with same signature
            ///of function that will point at[carry][assign]

            #endregion

            #region Delegate Example V1  variable carries function
            //MyDelegate del1 = new MyDelegate(Utility.PerDept);
            ////from this moment
            ////Utility.PerDept  has became name called del1
            //Employee e1 = new() {Id=1,Name="Sara",Age=22,Salary=1234,DeptId=30 };

            //Console.WriteLine(Utility.PerDept(e1));
            //Console.WriteLine(del1(e1));
            //Console.WriteLine(del1.Invoke(e1));

            //MathDelegate mathDelegate1=new MathDelegate(Utility.Add);
            //int x = 3, y = 4;
            //Console.WriteLine(Utility.Add(x,y));
            //Console.WriteLine(mathDelegate1(x,y));
            //Console.WriteLine(mathDelegate1.Invoke(3,4));


            #endregion

            #region Delegate Example V2 ->//anonymous function
            //MyDelegate del1 = new MyDelegate(Utility.PerDept);
            //MyDelegate del2=Utility.PerDept;

            ////anonymous function
            //MyDelegate del3=  delegate(Employee item)
            //{
            //    return item.DeptId == 10;
            //};

            //MyDelegate del4 = delegate (Employee MR) 
            //{
            //    return MR.Age>25;
            //};
            //Employee e1 = new() {Id=1,Name="Sara",Age=22,Salary=1234,DeptId=30 };
            //Console.WriteLine(del4(e1));
            #endregion

            #region Delegate Example V03  //=> [lambda expression][=> goes to]
            ////lambda expression -> anonymous function
            ////(input parms) => {return body;};
            /////(int x,int y)=>{return x>y};
            /////(int x,int y)=>{return x+y};
            //MyDelegate del = delegate (Employee abc) 
            //{
            //    return abc.Salary > 3000;
            //};

            //MyDelegate del2=  (Employee abc)=>
            //{
            //    return abc.Salary > 3000;
            //};

            //MyDelegate del3 = (Employee abc) =>
            //{
            //    return abc.Salary > 3000;
            //};

            //MyDelegate del4 = e1 => { return e1.Age > 25; };

            //MyDelegate del5 = e1 =>  e1.Age > 25;


            //MathDelegate mathdel1 = (r, s) => { return r + s; };
            //MathDelegate mathdel2 = (x, y) => x + y;

            //PrintDelegate<Employee> prnt1 = r => Console.WriteLine(r);
            //PrintDelegate<int> prnt2 = r => Console.WriteLine(r);

            //MathDelegate2<int, double> mathdel3 = (w, r) => w * r;
            //Console.WriteLine(mathdel3.Invoke(11,11));
            #endregion

            #region Filtration With Delegate
            MyDelegate del1 = FilterPer.PerDeptId;
            //del1 = r => r.Name.Contains("m");
            del1 = www => www.Name.Contains("m") && www.DeptId == 20;
            var filteredEmps = Filtration.FilterPerDelegate(employees, del1);

            filteredEmps = Filtration.FilterPerDelegate
                (employees, RD => RD.DeptId == 10);
            foreach (var employee in filteredEmps)
            {
                Console.WriteLine(employee);
            }
            #endregion

            #region Built-In Delegates
            #region Predicate takes one generic param and return bool
            //Predicate<int> IsEven = x => x % 2 == 0;
            //Console.WriteLine(IsEven(22));
            //Predicate<Employee> predicate2 = RD => RD.DeptId == 10;
            //Console.WriteLine(predicate2(employees.First()));
            #endregion
            #region Action takes from 0 up to 16 generic params and returns void
            //Action action1 = () => Console.WriteLine("Hello");
            //action1();
            //Action<int,int> action2= (w,r)=>Console.WriteLine(r+w);
            //Action<Employee> action3 = r => Console.WriteLine(r);
            #endregion
            #region Func takes from 0 up to 16 generic params and returns generic
            //Func<int> func1 = () => 22;
            //Func<int, int, int> func2 = (r, s) => r + s;
            //Func<int, int, bool> func3 = (r, s) => r > s;
            #endregion
            #endregion

            #region List of numbers 
            //List<int> nums=new List<int>();
            //List<string> names=new List<string>() {"Sara","Ali","Eman" };
            //List<Employee> employees2 = new List<Employee>();
            //for(int i = 1; i <= 100; i++) { nums.Add(i); }
            ////
            //////List<int> evenNums = new List<int>();
            //////foreach (var item in nums)
            //////{
            //////    if (item % 2 == 0)
            //////    {
            //////        evenNums.Add(item);
            //////    }
            //////}
            ////List<int> evenNums = nums.FindAll(item=>item%2==0);
            ////nums.RemoveAll(ww => ww % 2 == 0);
            ////names.RemoveAll(ww => ww.Contains("S"));
            ////var x=employees2.FindAll(ee => ee.Salary > 22);
            //////
            ////foreach (int i in nums)
            ////{
            ////    Console.WriteLine(i);
            ////}



            #endregion

            #region Future of linq
            //var filteredEmps = employees.Where(ww => ww.Salary > 5000);
            //filteredEmps=from item in employees
            //             where item.Salary>5000
            //             select item;
            #endregion

            #region Lab Assignments
            ///class Employee
            ///static repository
            ///filtration without delegate
            ///filtration with delegate
            ///
            ///try built in delegates func,predicate,action

            #endregion
        }
    }
}
