using System;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Animal Constructor: {Name}");
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
        Console.WriteLine($"Dog Constructor: {Name}, Breed: {Breed}");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} (a {Breed}) barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Buddy", "Golden Retriever");
        dog.Speak();
    }
}
