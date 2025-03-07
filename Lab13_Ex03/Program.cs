using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class AnimalSound
{
    public static void PlaySound(Animal animal)
    {
        animal.MakeSound();
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        AnimalSound.PlaySound(dog);
        AnimalSound.PlaySound(cat);
    }
}
