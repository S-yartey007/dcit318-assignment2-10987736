using System;

namespace OOP {

    class Animal {
        public virtual void MakeSound() {
            Console.WriteLine("GRRRRRR");
        }
    }

    class Dog : Animal {
        public override void MakeSound()
        {
           Console.WriteLine("Bark");
        }
    }
    class Cat : Animal {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program {
             public static void Main(String[] args) {
                Animal animal = new Animal();
                Dog dog = new Dog();
                Cat cat = new Cat();
                animal.MakeSound();
                dog.MakeSound();
                cat.MakeSound();

        }
    }
}