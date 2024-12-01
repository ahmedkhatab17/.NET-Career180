
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace LINQD2
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int deptid { get; set; }
        //  public List<suject> mysubjs { get; set; }


    }
    class dept
    {
        public int id { get; set; }
        public string name { get; set; }
        public string loc { get; set; }
    }
    class studentcompare : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return (x.id == y.id);
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.id;
        }
    }
    class suject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Student> sts = new List<Student>()
            //{
            //    new Student(){id=1, name="ali",age=22,mysubjs= new List<suject>()
            //    {
            //        new suject(){id=1 , name="SQL",duration=22},
            //        new suject(){id=2 , name="C#",duration=36},
            //        new suject(){id=3 , name="js",duration=22},

            //    }
            //    },

            //     new Student(){id=2, name="mostafa",age=22,mysubjs= new List<suject>()
            //    {
            //        new suject(){id=1 , name="html",duration=22},
            //        new suject(){id=2 , name="C#",duration=36},
            //        new suject(){id=3 , name="js",duration=22},

            //    }
            //    },
            //       new Student(){id=3, name="mona",age=22,mysubjs= new List<suject>()
            //    {
            //        new suject(){id=1 , name="html",duration=22},
            //        new suject(){id=2 , name="ES6",duration=36},
            //        new suject(){id=3 , name="js",duration=22},

            //    }
            //    },
            //};
            #region select many

            //var q0 = sts.Select(s => new { s.name, s.mysubjs });

            //foreach (var s in q0)
            //{
            //    Console.WriteLine(s.name);
            //    foreach(var item in s.mysubjs)
            //    {
            //        Console.WriteLine(item.name);
            //    }
            //}
            //  var q1 = sts.SelectMany(s => s.mysubjs, (st, s) => new { st.name, st.age, subjectname = s.name, s.duration });
            //foreach (var s in q1)
            //{
            //    Console.WriteLine(s);
            //}

            //List<string> names = new List<string>() { "ali", "mostafa", "mona", "ola" };
            //List<int> num = new List<int>() { 1, 6, 3, 5, 7, 8 };
            //var q2 = names.SelectMany(n=>num, (na, num) => new {na ,num });
            //foreach(var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  of type, reverse

            //var li = new ArrayList() { "ali", 1, "mostafa", 2.2F };
            //var q2 = li.OfType<string>().Reverse();
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Distinct


            //List<string> names = new List<string>() { "mostafa", "ali", "mostafa", "ola", "mona", "ola" };
            //var q3 = names.Distinct();
            //foreach (string name in q3)
            //{
            //    Console.WriteLine(name);
            //}
            //Student s1 = new Student() { id = 1, name = "ali", age = 22 };
            //List<Student> students = new List<Student>()
            //{
            //    new Student() { id = 1, name = "ali", age = 22 },
            //    new Student() { id = 1, name = "mona", age = 22 },
            //    new Student(){id=2,name="mostafa",age=20},
            //    new Student() { id = 1, name = "ali", age = 22 },
            //};

            //var q3 = students.Distinct( new studentcompare());
            //foreach(var student in q3)
            //{
            //    Console.WriteLine(student.name);
            //}




            #endregion
            #region  union,Concat,Intersect

            //List<string> n1 = new List<string>() { "C#", "sql", "html", "C#" };
            //List<string> n2= new List<string>() { "js", "sql", "ES6", "agile" };

            ////var q3 = n1.Concat(n2);
            //var q3 = n1.Except(n2);
            //foreach ( var x in q3)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            //List<Student> sts = new List<Student>()
            //{
            //    new Student(){id=1,name="ali",age=22,deptid=1},
            //    new Student(){id=2,name="mona",age=22,deptid=2},
            //    new Student(){id=4,name="ola",age=22},
            //    new Student(){id=3,name="mostafa",age=22,deptid=1},
            //    new Student(){id=5,name="ahmed",age=22,deptid=2},
            //};

            List<dept> departments = new List<dept>()
            {
                new dept(){id=1 , name="SD",loc="lab1"},
                new dept(){id=2 , name="os",loc="lec1"},
                new dept(){id=3 , name="El",loc="lab2"},
            };

            #region  join 


            //var q3 = sts.Join(departments, n => n.deptid, d => d.id,
            //    (s, d) => new { s.name, depatmentname = d.name }


            //    );

            //foreach(var item in q3)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region groupjoin
            //var q5 = departments.GroupJoin(sts, n => n.id, s => s.deptid,

            //    (d, st) => new { d.name, st }
            //    );
            //foreach (var item in q5)
            //{
            //    Console.WriteLine(item.name);
            //    foreach (var item2 in item.st)
            //    {
            //        Console.WriteLine(item2.name);
            //    }
            //    Console.WriteLine("-------------------");
            //}

            //var q6 = sts.GroupJoin(departments,
            //    s => s.deptid,
            //    d => d.id,
            //    (s, d) => new { s.name, d });

            //foreach( var item in q6)
            //{
            //    Console.WriteLine(item.name);
            //    foreach(var item2 in item.d)
            //    {
            //        Console.WriteLine(item2.name);
            //    }
            //}

            #endregion

            #region elementAt

            //  var q2=sts.ElementAtOrDefault(2)



            #endregion
            #region  all ,any

            //    var q1 = sts.Any(n => n.age == 20);
            //var q1 = sts.All(n => n.age == 22);
            //Console.WriteLine(q1);

            #endregion
            #region SequenceEqual
            //int[] arr = { 3, 5, 22, 3, 5 };
            //var q2 = arr.Aggregate((x, y) => x * y);
            // //3*5
            // //15*22
            //Console.WriteLine(q2);


            List<Student> sts = new List<Student>()
            {
                new Student(){id=1,name="ali",age=20,deptid=1},
                new Student(){id=2,name="mona",age=21,deptid=2},
                new Student(){id=4,name="ola",age=22},
                new Student(){id=3,name="mostafa",age=19,deptid=1},
                new Student(){id=5,name="ahmed",age=22,deptid=2},
            };
            //List<Student> st2 = new List<Student>()
            //{
            //    new Student(){id=1,name="ali",age=20,deptid=1},
            //    new Student(){id=2,name="mona",age=21,deptid=2},
            //    new Student(){id=4,name="ola",age=22},
            //    new Student(){id=3,name="mostafa",age=19,deptid=1},
            //    new Student(){id=5,name="ahmed",age=22,deptid=2},
            //};
            //var q1 = sts.Where(n => n.id > 3);
            //var q2 = sts.Where(n => n.age >= 22);

            //var q3 = sts.SequenceEqual(st2,new studentcompare());
            //Console.WriteLine(q3);
            #endregion
            #region empty ,repeat,range 
            //  var q1 = Enumerable.Empty<Student>();
            ////  var q2 = Enumerable.Range(10,15);
            //  var q2 = Enumerable.Repeat(10,15);
            //  foreach ( var item in q2)
            //  {
            //      Console.WriteLine(item);
            //  }

            #endregion
            #region defualtifempty
            var q10 = sts.Where(n => n.age >21).DefaultIfEmpty<Student>(new Student() { id = 0, name = "nostudent" }); ;
            Console.WriteLine(q10.ToList().Count);

            #endregion

        }
    }
}
