namespace LearnItCSD05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Definition
            ///inheritance
            ///extend properties and methods from DT to another one
            ///

            ///TypeA
            /////x
            /////y
            /////FunOne()
            /////FunTwo()

            ///TypeB
            /////y
            /////z
            /////FunTwo()
            /////FunThree()

            ///copy & paste -> bad Programming

            ///inheritance Solution

            ///Base
            /////y
            /////FunTwo()

            ///TypeA Inherits Base
            /////x
            /////FunOne()

            ///TypeB Inherits Base
            /////z
            /////FunThree()

            //in inheritance:
            ///child DT inheris EVERYTHING from Parent DT

            #endregion

            #region Inheritance Example V01
            ////In main , we can access public only via object name
            //Parent p1=new Parent();  //8B   //x|0| y|0|

            //Child c1 =new Child();  //12B    //x|0| y|0| z||
            //o/p
            //parent def ctor
            //child def ctor

            //Child c2 = new Child(1, 2, 3);
            ////o/p
            ////parent def ctor
            ////child 3p ctor
            //Console.WriteLine(c2.SumXYZ()); //6
            //Console.WriteLine(c2.SumXY()); //3
            #endregion

            #region protected[smart private]
            ///private member is inherited but cannot be accessed
            ///is there any way to access those members inside child DT??? YES
            ///if they became protected
            ///
            ///protected ->[inheritace]
            ///member can be accessed
            ///inside class
            ///and acessed inside chain of inheritance
            ///ONLY
            #endregion

            #region Overriding -> [inheritance]
            //fn overriding:
            ///function has same name, same parameters
            ///but body/implementation is different in Child DT
            #endregion

            #region Inheritance Example V02
            ////Parent p1=new Parent();
            //////p1.x = 10; //compile Error  //inaccessible protected

            //Child c1= new Child(1,2,3);
            //Console.WriteLine(c1.Sum()); //6
            ////print c1.Parent::Sum(); //c++ wise //3

            #endregion

            #region Inheritance Example V03
            //////Rect r1 = new Rect(1,2);
            ////////o/p
            ////////geo def ctor
            ////////rect ctor

            ////SquareV2 s1= new SquareV2();
            //////o/p
            //////geo ctor
            //////rect ctor
            //////sqv2 ctor
            /////

            /////issue
            //Square s1 = new Square(10);
            ////s1.Dim1 = 3;
            ////s1.Dim2 = 4;
            //Console.WriteLine(s1.CArea()); //12

            //Circle c1=new Circle(7);
            ////c1.Dim1 = 3;
            ////c1.Dim2 = 4;
            //Console.WriteLine(c1.CArea());//153.52
            #endregion

            #region Early/Static Binding
            //Base b1=new Base(); //8B Heap
            //b1.Show();  //I'm Base
            ////compiler will retrieve copy of [Show] that related to reference DT

            //Derived d1= new Derived(); //12B
            //d1.Show();  //I'm Derived
            ////compiler will retrieve copy of [Show] that related to reference DT

            ////الأب يحتوي جميع ابناؤه
            ////inheritance is-a

            ////car is a viechle
            ////bus is a viechle
            //Base b2 = new Derived(1, 2, 3);
            //b2.Show(); //i'm Base
            ////compiler will retrieve copy of [Show] that related to reference DT

            //Base b3 = new Derived2(1, 2, 3, 4);
            //b3.Show(); //I'm Base
            ////compiler will retrieve copy of [Show] that related to reference DT


            //Derived d2 = new Derived2();
            //d2.Show(); //i'm Derived
            ////compiler will retrieve copy of [Show] that related to reference DT


            ///Early / Static Binding  [Compile Time]:
            ///when reference of parent points object of child
            ///and call overridden fn
            ///compiler early in compile Time will retrieve
            ///copy of fn thar related to reference DT NOT copy
            ///that related to object DT
            ///

            ////Logic
            ///when create reference of parent that points object from child
            ///and call overridden fn
            ///compiler retrieve copy of object DT instead of Reference DT
            /////Base b2 = new Derived(1, 2, 3);
            //////b2.Show();  //i'm Derived
            #endregion

            #region Late/Dynamic Binding [runtime]
            /////when create reference of parent that points object from child
            /////and call overridden fn
            /////compiler retrieve copy of object DT instead of Reference DT
            /////
            /////how???
            /////1- function that will be oerridden in base class[first level] must be virtual
            /////2- overridden fn must include [override] keyword 
            /////3- create reference from base points object from its childs
            /////


            //Base b1 = new Derived();
            //b1.Show(); //i'm derived
            //Derived d1= new Derived2();
            //d1.Show(); //i'm derived2
            //Base b2 = new Derived2();
            //b2.Show(); //i'm derived2
            #endregion

            #region Abstract class   errors common with====>interface
            //Geoshape g1= new Geoshape();
            //Human h1=new Human();

            //abstract class : class we cannot create object from it
            //Geoshape g2;  //Reference YESSS

            ////virtual fn??? Late Binding  => overriding
            ///
            ///sealed class : class can inherit but cannot be inherited

            ///struct canot inherit and cannot be inherited
            #endregion


            #region Lab Assignments
            ///1-try class geoshape , rect ,square,circle ,Tri
            ///2-try early vs. late with Base,Derived,Derived2   [virtual]
            ///3-Try Abstract class with geoshape
            ///
            ///System.Object 
            #endregion
        }
    }
}
