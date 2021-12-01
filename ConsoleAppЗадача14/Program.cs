using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();
            cat1.ShowInfo();
            dog1.ShowInfo();
        }
    }
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal()
        {
            Name = default;
        }
        public abstract void Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    public class Cat : Animal
    {
        public override string Name { get; set; }

        public Cat()
        {
            Name = "Котик";
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public override void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    public class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog()
        {
            Name = "Песик";
        }

        public override void Say()
        {
            Console.Write("Гав");
        }
        public override void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
            Console.ReadKey();
        }
    }
}
