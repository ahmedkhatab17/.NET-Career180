using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD09
{
    //Historical way for Repository pattern
    //business
    //Person
    public interface IPersonService
    {
        List<Person> GetPeople();
        Person GetPerson(int id);
        void Add(Person person);
        void Update(Person person);
        void Delete(int id);
    }
    public class PersonService : IPersonService
    {
        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
    public interface IInstructorService
    {
        List<Instructor> GetPeople();
        Instructor GetPerson(int id);
        void Add(Instructor value);
        void Update(Instructor value);
        void Delete(int id);
    }
    public class InstructorService : IInstructorService
    {
        public void Add(Instructor value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Instructor GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor value)
        {
            throw new NotImplementedException();
        }
    }
    ////////////////////////////////////////////////////
    public interface ICompanyService<T>
    {
        List<T> GetAll();
        T GetPerson(int id);
        void Add(T value);
        void Update(T value);
        void Delete(int id);
    }
    public class PersonController : ICompanyService<Person>
    {
        public void Add(Person value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person value)
        {
            throw new NotImplementedException();
        }
    }
    public class InstructorController : ICompanyService<Instructor>
    {
        public void Add(Instructor value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Instructor GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor value)
        {
            throw new NotImplementedException();
        }
    }

    ///////////////////////////////////////////////////
    public interface ILearnItService<T>
    {
        List<T> GetAll();
        T GetPerson(int id);
        void Add(T value);
        void Update(T value);
        void Delete(int id);
    }
    public class LearnItService<T> : ILearnItService<T>
    {
        public void Add(T value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T value)
        {
            throw new NotImplementedException();
        }
    }

    class EntryPoint
    {
        static void OldMain() 
        {
            LearnItService<Person> p1= new LearnItService<Person>();
            LearnItService<Instructor> i1= new LearnItService<Instructor>();

            Math1 m = new Math1();
            Math2<double, double> m2 = new Math2<double, double>();
            Math2<int,double> m3=new Math2<int,double>();
        }
    }
    ///////////////////////////////////////////////////
    //Execlusive with interface,delegate in,out
    public interface IMathService<in T,out U>
    {
        U Add(T left,T right);
        U Sub(T left,T right);
        U Mul(T left,T right);
        U Div(T left,T right);
    }
    public class Math1 : IMathService<int, double>
    {
        public double Add(int left, int right)
        {
            throw new NotImplementedException();
        }

        public double Div(int left, int right)
        {
            throw new NotImplementedException();
        }

        public double Mul(int left, int right)
        {
            throw new NotImplementedException();
        }

        public double Sub(int left, int right)
        {
            throw new NotImplementedException();
        }
    }

    public class Math2<T, U> : IMathService<T, U>
    {
        public U Add(T left, T right)
        {
            throw new NotImplementedException();
        }

        public U Div(T left, T right)
        {
            throw new NotImplementedException();
        }

        public U Mul(T left, T right)
        {
            throw new NotImplementedException();
        }

        public U Sub(T left, T right)
        {
            throw new NotImplementedException();
        }
    }


}
