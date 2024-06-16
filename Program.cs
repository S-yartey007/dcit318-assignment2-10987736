using System;

namespace OOP {

   public class Animal {
        public virtual void MakeSound() {
            Console.WriteLine("GRRRRRR");
        }
    }

    //Inheritance
   public class Dog : Animal {
        //Method Overriding
        public override void MakeSound()
        {
           Console.WriteLine("Bark");
        }
    }
    //inheritance 
        public  class Cat : Animal {
        //Method Overriding
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    //Abstract Classes and Methods
    public abstract class Shape {
        public abstract float GetArea();
    }
    //Derived class
    public class Circle : Shape {
        public const double PI = 3.1415926535897931;
        public float Radius {get;set;}
        
        public Circle(float radius) {
            Radius = radius;
        }

        public override float GetArea() {
           float squaredRadius =(float) Math.Pow(Radius,2);
           float pi = (float) PI;
           return squaredRadius * pi;
        }
    }

    //Derivide class
    public class Rectangle : Shape {
        public float Length {get;set;}
        public float Width {get;set;}
        public Rectangle (float length,float width) {
            Length = length;
            Width = width;
        }
        public override float GetArea()
        {
            return Length * Width;

        }
    }
    //interfaces
    public interface IMovable {
         void Move();
    }
    //Derived classes
    public class Car : IMovable {
     public void Move() {
        Console.WriteLine("Car is moving");
     }
    }
    public class Bicycle : IMovable {
       public void Move() {
            Console.WriteLine("Bicycle is moving");
        }
    }
    
  public class Program {
             public static void Main(String[] args) {
                //Instances of Animal, Dog and Cat
                Animal animal = new Animal();
                Dog dog = new Dog();
                Cat cat = new Cat();

                //Calling the inherited methods
                animal.MakeSound();
                dog.MakeSound();
                cat.MakeSound();
                
                //Instances of Rectangle and Circle
                Rectangle rectangle = new Rectangle(34,34);
                Circle circle = new Circle(34);

                //Printing value of inherited methods
                Console.WriteLine(circle.GetArea());
                Console.WriteLine(rectangle.GetArea());

                //Instances of Car and Bicycle
                Car car = new Car();
                Bicycle bicycle = new Bicycle();

                //Calling methods of Car and bicycle
                car.Move();
                bicycle.Move();



        }
    }
}