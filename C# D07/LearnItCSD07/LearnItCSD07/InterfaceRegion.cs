using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD07
{
    public interface IMyInterface1
    {
        void SignIn();
        void SignOut();
        string Name { set; get; } 
    }

    public interface IMyInterface2 
    {
        decimal Salary {  set; get; }
        void SetCommission(decimal value);
        void RevokeDeduction(decimal value);
        void SignIn();
    }


    /////////////////////////////////////////////////
    ////class that implements interfaces
    //public class Parent { }
    //public class CompanyService : IMyInterface1, IMyInterface2
    //{
    //    public string Name
    //    {
    //        get;

    //        set; 
    //    }

    //    public decimal Salary
    //    {
    //        set;get;
    //    }

    //    public void RevokeDeduction(decimal value)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SetCommission(decimal value)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SignIn()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SignOut()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //////////////////////////////////////////////////////

    class Draft : IMyInterface1, IMyInterface2
    {
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal Salary
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void RevokeDeduction(decimal value)
        {
            throw new NotImplementedException();
        }

        public void SetCommission(decimal value)
        {
            throw new NotImplementedException();
        }

        //if you wanna implement 2 functions with same name 
        //from different interfaces 
        //you must implement it explicitly
        ///private void IMyInterface1.SignIn(){}
        ///private void IMyInterface2.SignIn(){}

        //How to access it from entry point
        //via reference from interface

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        void IMyInterface1.SignIn()
        {
            throw new NotImplementedException();
        }

        void IMyInterface2.SignIn()
        {
            throw new NotImplementedException();
        }
    }

}
