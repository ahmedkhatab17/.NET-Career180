using System.Reflection.Metadata.Ecma335;

namespace LINQD1
{
    class student
    {
        public required int id { get; init; }
        public string fname { get; init; }
        public string lname { get; init; }
        public int age { get; init; }

        public override string ToString()=>$"{id}-{fname} {lname} -{age} yearsold";
        

        //public int sum(params int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int i in arr)
        //    {
        //        sum += i;
        //    }
        //    return sum;

        //}
    }

    class calc  
    {
      //  public int sum (int n1 , int n2)
      //  {
      //      return n1 + n2;
       // }
    }

   static class stringextentation
    {
        public static int wordcount(this string s)
        {
            string[] arr = s.Split(' ');
            return arr.Length;
        }
    }
    internal class Program
    {
        static void calc(int x ,int y, Func<int,int,int> mydel)
        {
            Console.WriteLine(mydel.Invoke(x,y));
        }
        static void Main(string[] args)
        {

            #region C# feature
            #region implicit type local variable var
            //int x=4;
            //var y = "ahmed";
            //var z=1;
            ////z="ali"xxxxxx
            //// var i = nullxxxxx;
            ////var i = "ali";
            ////i = null;
            //int[] arr = { 1, 2, 3 };

            //foreach(var i in arr)
            //{

            //}


            #endregion
            #region object init
            // student s = new student() { id = 1, fname = "ali", lname = "mohamed" };
            //s.age = 5xxxxxxx;

            //student s1 = new student();
            //s1.id = 2;

            //student s2 = new student() { id=3,fname="ahmed"};

            //student s3= new student() { id=3,fname="ahmed"};
            // student s= new student() { id = 1 };
            //s.sum(new int[] { 1, 2, 55, 66, 77 });
            //s.sum(44, 66, 77, 88, 99);
            #endregion
            #region anynoums object
            //var+new+object init
            //  var obj = new { employeeid = 4, fullname = "ali ahmed" };
            ////  obj.employeeid = 3xxxxxxxx;
            //  Console.WriteLine(obj.employeeid);

            //student s = new student() { id = 1, fname = "ali", lname = "ahmed", age = 22 };

            //var myobj = new { fullname = s.fname + " " + s.lname, studentage = s.age };
            //var obj2 = new { s.fname, age=s.age+1 };
            //Console.WriteLine(obj2);
            #endregion

            #region anynoums method
            //calc c = new calc();
            ////Func<int, int, int> mydel = c.sum;
            //Func<int, int, int> mydel = delegate (int n1, int n2)
            //{
            //    return n1 + n2;
            //};
            // lymada exp
            //(input)=>{body,return}
            //Func<int, int, int> mydel2 =  (n1,n2)=> n1 + n2;


            //Console.WriteLine(mydel.Invoke(2,3));
            // calc(8, 4, delegate (int n1, int n2) { return n1 - n2; });
            // calc(8, 4,(n1, n2)=>  n1 - n2 );

            //List<string> sts = new List<string>() { "ali", "mohamed", "ola", "mona" };
            //List<string> r = sts.FindAll(delegate (string txt) { return txt.Contains("mo"); });
            //List<string> r = sts.FindAll(txt=>txt.Contains("mo"));

            //foreach (string s in r)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region extenation method
            //     string txt = "ahmed mohamed ali";
            //     //  txt.wordcou
            //     stringextentation.wordcount(txt);
            //     txt.wordcount();
            //int r=     txt.wordcount();

            #endregion

            #endregion
            #region LINQ
            List<student> sts = new List<student>()
            {
                new student(){id=1 ,fname="ali", lname="mohamed",age=12},
                new student(){id=4 ,fname="mona", lname="ahmed",age=15},
                new student(){id=5 ,fname="ola", lname="salem",age=13},
                new student(){id=3 ,fname="mohamed", lname="ahmed",age=17},
                new student(){id=7 ,fname="mostafa", lname="mohamed",age=12},
            };

            #region where
            // var q1 = Enumerable.Where(sts, s => s.age > 13);
            //var q1 = sts.Where(s => s.age > 13);
            //var q2 = sts.Where(s => s.fname.Contains("m"));
            //var q3 = sts.Where(s => s.fname.Contains("m") && s.age>13);
            #endregion
            #region select
            //method exp
            //var q4 = sts.Select(n => n.fname);
            //var q5 = sts.Where(s => s.age > 12).Select(s => s.fname);
            //  var q5 = Enumerable.Select(Enumerable.Where(sts, s => s.age > 12), s => s.fname);

            //query exp
            //var q5 = from s in sts
            //         where s.age > 12
            //         select s.fname;


            //var q6 = sts.Where(n => n.age > 12).Select(n => new { n.fname, n.age });
            //foreach (var s in q6) {
            //    Console.WriteLine(s);

            //}
            #endregion
            #region LINQ execuation
            //var q7 = sts.Where(n => n.age > 12).ToList();

            //sts.Add(new student() { id = 10, fname = "test", lname = "user", age = 15 });
            //foreach (var s in q7) {
            //    Console.WriteLine(s);
            //}
            #endregion
            #region  casting operators
            //var q10 = sts.Where(n => n.age > 12).ToArray();
            // var q10 = sts.Where(n => n.id ==5).SingleOrDefault();
            //var q10 = sts.Where(n => n.id ==5).First();
            //     var q10 = sts.Where(n => n.id >1).LastOrDefault();
            //var q11 = sts.Select(s => s.lname).Distinct();
            ////  Console.WriteLine(q11);
            //foreach (var s in q11)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion
            #region  min ,max , avg ,count ,sum ,take ,skip
            //var q12 = sts.Select(n => n.age).Min();
            //var q13 = sts.Select(n => n.age).Max();
            //var q14 = sts.Select(n => n.age).Average();
            //Console.WriteLine(q14);

            //var q13 = sts.Take(2).LastOrDefault();
            ////var q13 = sts.Skip(2);
            //Console.WriteLine(q13);
            ////foreach (student t in q13)
            ////{
            ////    Console.WriteLine(t);
            ////}
            #endregion
            #region  order
           // var q13 = sts.Where(n => n.age > 10).OrderBy(n => n.age);
            //var q13 = sts.Where(n => n.age > 10).OrderBy(n => n.age).ThenByDescending(n=>n.fname).Take(2);
            //foreach (var s in q13) {
            //    Console.WriteLine(s);
            //}



            #endregion
            #endregion
        }
    }
}
