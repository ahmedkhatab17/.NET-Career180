using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD04
{
    public class Person
    {
        #region Traditional way
        #region Data fields
        //int id;
        //string name;
        //int age;
        //decimal price;
        #endregion
        #region Property
        //public int Id
        //{
        //    get
        //    {
        //        return id;
        //    }

        //    set
        //    {
        //        id = value;
        //    }
        //}

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    }
        //}

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }

        //    set
        //    {
        //        age = value;
        //    }
        //}

        //public decimal Price
        //{
        //    get
        //    {
        //        return price;
        //    }

        //    set
        //    {
        //        price = value;
        //    }
        //}
        #endregion
        #endregion

        #region Alternitave Way [Automatic Property]  MCU
        public int Id { get; set; }  //-> compile time private int id; public int Id{set id=value ; get return id;} 
        public string Name { get; set; }
        public int Age {  get; set; }
        public decimal Price {  get; set; }

        ////FORBIDDEN
        //string address;
        //public string Address { set; get; }
        #endregion
    }
}
