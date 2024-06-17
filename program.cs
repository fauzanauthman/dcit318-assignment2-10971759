using System; // Including System namespace for common functionalities

// Inheritance and Polymorphism Example
abstract class Shape  // Abstract class for shapes
{
  public abstract double GetArea();  // Abstract method to calculate area (must be implemented by derived classes)
}

class Circle : Shape  // Derived class representing Circle
{
  private double radius;

  public Circle(double radius)
  {
    this.radius = radius;
  }

  public override double GetArea()  // Overridden method to calculate circle area
  {
    return Math.PI * radius * radius;
  }
}

class Rectangle : Shape  // Derived class representing Rectangle
{
  private double width;
  private double height;

  public Rectangle(double width, double height)
  {
    this.width = width;
    this.height = height;
  }

  public override double GetArea()  // Overridden method to calculate rectangle area
  {
    return width * height;
  }
}

// Interface and Polymorphism Example
interface IMovable  // Interface for objects that can move
{
  void Move();
}

class Car : IMovable  // Derived class representing Car implementing IMovable
{
  public void Move()
  {
    Console.WriteLine("Car is moving");
  }
}

class Bicycle : IMovable  // Derived class representing Bicycle implementing IMovable
{
  public void Move()
  {
    Console.WriteLine("Bicycle is moving");
  }
}

class MainClass
{
  public static void Main(string[] args)
  {
    // Animal Inheritance Example (commented out as requested in previous interaction)
    // Animal animal = new Animal();  // Abstract classes cannot be instantiated directly
    // Dog dog = new Dog();
    // Cat cat = new Cat();

    // dog.MakeSound(); // Prints "Bark" (if uncommented)
    // cat.MakeSound(); // Prints "Meow" (if uncommented)

    // Shape and Area Calculation Example
    Shape circle = new Circle(5);
    Shape rectangle = new Rectangle(4, 3);

    Console.WriteLine($"Circle Area: {circle.GetArea()}");
    Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

    // Interface and Move Example
    IMovable car = new Car();
    IMovable bicycle = new Bicycle();

    car.Move(); // Prints "Car is moving"
    bicycle.Move(); // Prints "Bicycle is moving"
  }
}
