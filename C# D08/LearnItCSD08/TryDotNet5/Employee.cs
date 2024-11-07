using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDotNet5
{
    public struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        ////in .net 5 + c# 9
        ////in struct
        ////there is parameterless ctor you cannot write it explicitly
        ///PLUS
        ///in pametererized ctor , YOU MUST FULLY INITIALIZE ALL DATA
        //public Employee()
        //{
        //    Id = 0;
        //    Name = "Ali";
        //    Age = 22;
        //}

        public Employee(int _id,string _name,int _age)
        {
            Id = _id;
            Name = _name;
            Age = _age;
        }

    }
}
