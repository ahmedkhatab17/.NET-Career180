using System;
using System.Linq;
using System.Collections.Generic;
using Lab;

namespace Lab
{

    class Subject { 
        public int Code { get; set; } 
        public string Name { get; set; } 
    }

    class Student { 
        public int ID { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public Subject[] Subjects { get; set; } 
    }
}
internal class Program
    {
        static void Main(string[] args)
        {

        #region 1
        #region Query1
        //List<int> list = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

        //var distinctSortedNumbers = list.Distinct().OrderBy(x => x).ToList();

        //foreach (var x in distinctSortedNumbers)
        //{
        //    Console.WriteLine(x);
        //}
        #endregion

        #region Query2
        //var multipliedNumbers = distinctSortedNumbers.Select(n => new { n, Multi = n * n });

        //foreach (var x in multipliedNumbers)
        //{
        //    Console.WriteLine($"Number = {x.n}, Multiply = {x.Multi}");
        //}
        #endregion
        #endregion


        #region 2

        #region Query3
        //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

        //var namesWithLen3 = names.Where(names => names.Length == 3);
        //foreach (var name in namesWithLen3)
        //{
        //    Console.WriteLine(name);
        //}
        #endregion

        #region Query4
        //var namesWithA = names.Where(names => names.IndexOf('a', StringComparison.OrdinalIgnoreCase) >= 0).OrderBy(names => names.Length);

        //foreach (var name in namesWithA) { Console.WriteLine(name); }
        #endregion

        #region Query5
        //var first2Names = names.Take(2).ToList();

        //foreach (var name in first2Names) { Console.WriteLine(name); }
        #endregion

        #endregion


        #region 3
        #region Query6
        //List<Student> students = new List<Student>() {
        //    new Student() { ID = 1, FirstName = "Ali", LastName = "Mohammed", Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 33, Name = "UML" } } },
        //    new Student() { ID = 2, FirstName = "Mona", LastName = "Gala", Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 34, Name = "XML" }, new Subject() { Code = 25, Name = "JS" } } },
        //    new Student() { ID = 3, FirstName = "Yara", LastName = "Yousf", Subjects = new Subject[] { new Subject() { Code = 22, Name = "EF" }, new Subject() { Code = 25, Name = "JS" } } },
        //    new Student() { ID = 1, FirstName = "Ali", LastName = "Ali", Subjects = new Subject[] { new Subject() { Code = 33, Name = "UML" } } },
        //};


        //var DisplayNameSub = students.Select(s => new { s.FirstName, s.LastName, s.Subjects.Length }).ToList();
        //foreach (var student in students)
        //{
        //    Console.WriteLine($"Name = {student.FirstName} {student.LastName}, NumOfSubjects = {student.Subjects.Length}");
        //}
        #endregion

        #region Query7
        //var DisplayOrder = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).ToList();

        //foreach (var student in DisplayOrder)
        //{
        //    Console.WriteLine($"{student.FirstName} {student.LastName}");
        //}
        #endregion 
        #endregion


    }
}
