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
  public class Program {
             public static void Main(String[] args) {
                Animal animal = new Animal();
                Dog dog = new Dog();
                Cat cat = new Cat();
                animal.MakeSound();
                dog.MakeSound();
                cat.MakeSound();
                Rectangle rectangle = new Rectangle(34,34);
                Circle circle = new Circle(34);
                Console.WriteLine(circle.GetArea());
                Console.WriteLine(rectangle.GetArea());

        }
    }
}