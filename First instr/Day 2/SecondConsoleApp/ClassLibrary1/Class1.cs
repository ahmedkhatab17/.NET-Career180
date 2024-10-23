using SecondConsoleApp;

namespace ClassLibrary1
{
    public class Class1
    {
      

        public readonly IPerson _person;
        public Class1(IPerson persone)
        {
            _person = persone;
        }


        public void CreatePerson()
        {
            _person.Create();
        }

        public void NEWMethod()
        {
            Vehicle vehicle = new Vehicle("2");
             
            Other.MethodOther();
        }


        
        public static class Other
        {
            public static void MethodOther()
            {

            }
        }
    }
}
