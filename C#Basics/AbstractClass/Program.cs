using System.Runtime.InteropServices;

namespace AbstractClass
{
    public interface IInterface
    {
        void print();
    }
    public abstract class ParentAnimal1:IInterface
    {
        public abstract void AnimalColor();

        public void print()
        {
            Console.WriteLine("Interface");
            
        }
    }
    public abstract class ParentAnimal:ParentAnimal1
    {
        public override abstract void  AnimalColor();
    }
public abstract class Animal:ParentAnimal
{
    public abstract string Sound { get; }

    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }
}

public class Cat : Animal
{
       
        
    public override string Sound => "Meow";

        public override void AnimalColor()
        {
            Console.WriteLine("Colour is white");
        }

        public override void Move()
    {
        Console.WriteLine("Walking like a cat...");
    }

}

public class Dog : Animal
{
    public override string Sound => "Woof";

        public override void AnimalColor()
        {
            Console.WriteLine("Colour is black");
        }

        public override void Move()
    {
        Console.WriteLine("Running like a dog...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ParentAnimal1[] animals = new ParentAnimal1[] { new Cat(), new Dog() };

        foreach (ParentAnimal1 animal in animals)
        {
            Console.WriteLine($"The {animal.GetType().Name} goes ");
            
                animal.AnimalColor();
        }
    }
}
}
