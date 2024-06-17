class Animal
{
  public virtual void MakeSound()
  {
    Console.WriteLine("Some generic sound");
  }
}

class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Bark");
  }
}

class Cat : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Meow");
  }
}

class MainClass
{
  public static void Main(string[] args)
  {
    Animal animal = new Animal();
    Dog dog = new Dog();
    Cat cat = new Cat();

    animal.MakeSound(); // Prints "Some generic sound"
    dog.MakeSound();     // Prints "Bark"
    cat.MakeSound();     // Prints "Meow"
  }
}
using System;

abstract class Shape
{
  public abstract double GetArea();
}

class Circle : Shape
{
  private double radius;

  public Circle(double radius)
  {
    this.radius = radius;
  }

  public override double GetArea()
  {
    return System.Math.PI * radius * radius;
  }
}

class Rectangle : Shape
{
  private double width;
  private double height;

  public Rectangle(double width, double height)
  {
    this.width = width;
    this.height = height;
  }

  public override double GetArea()
  {
    return width * height;
  }
}

class MainClass
{
  public static void Main(string[] args)
  {
    // Create circle and rectangle instances
    Circle circle = new Circle(5);
    Rectangle rectangle = new Rectangle(4, 3);

    // Calculate and display areas
    Console.WriteLine($"Circle Area: {circle.GetArea()}");
    Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
  }
}
