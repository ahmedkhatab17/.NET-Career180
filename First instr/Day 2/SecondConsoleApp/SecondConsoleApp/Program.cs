using SecondConsoleApp;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        calculator.Add(1, 1);
        calculator.Add(1.0, 1.0);
        calculator.Add(1, 1, 1);

        // Polymorphism: The reference type is Animal, but the actual object is a Dog
        Animal myAnimal = new Dog();
        myAnimal.Speak(); // Output: The dog barks.
        myAnimal.Eat();

        // Polymorphism: The reference type is Animal, but the actual object is a Cat
        myAnimal = new Cat();
        myAnimal.Speak(); // Output: The cat meows.
        myAnimal.Eat();

        // Polymorphism: The reference type is Animal, but the actual object is a Cat
        myAnimal = new Dug();
        myAnimal.Speak(); // Output: The cat meows.
        myAnimal.Eat();



        // Cannot instantiate the abstract class
        // Animal animal = new Animal(); // Error: Cannot create an instance of the abstract class 'Animal'
        AnimalAbstact myDog = new DogAbstract();
        myDog.MakeSound();  // Output: The dog barks.
        myDog.Eat();        // Output: The animal is eating.
        AnimalAbstact myCat = new CatAbstract();
        myCat.MakeSound();  // Output: The cat meows.
        myCat.Eat();        // Output: The animal is eating.



        Vehicle vehicle = new Vehicle("Honda");
        //vehicle.Make = "Hondaaaaa";
        Console.WriteLine(vehicle.Make);

        //Car car1 = new Car(2);
        //Car car2 = car1;  // car2 references the same object as car1
        //car2.Make = "Toyota";
        //Console.WriteLine(car1.Make);  // Outputs: Toyota

        Point point1 = new Point(10, 20);
        Point point2 = point1;  // point2 is a copy of point1


        point2.X = 50;
        Console.WriteLine(point1.X);  // Outputs: 10 (unchanged)


        Helper.SendEmail("ant@d.c");
        var role = Helper.RoleAdmin;
        Helper.RoleAdmin = "Admin";

        if (role == Helper.RoleAdmin)
        {

        }
    }
}

