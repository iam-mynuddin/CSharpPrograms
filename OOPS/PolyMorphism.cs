using System;
namespace OOPS
{
    
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

static class Polymorphism
{
    public static void Run()
    {
       Animal animal1 = new Animal();
       Animal animal2 = new Dog();
       Animal animal3 = new Cat();

       animal1.MakeSound();
       animal2.MakeSound();
       animal3.MakeSound();
    }
}

class A
{
  public virtual void Write()
  {
    Console.WriteLine("Run from class A");
  }
}

class B:A
{
    public override void Write()
    {
        Console.WriteLine("Run from class B");
    }
}

}