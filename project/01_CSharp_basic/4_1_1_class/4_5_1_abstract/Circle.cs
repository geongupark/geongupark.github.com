// Circle.cs
namespace _4_5_1_abstract
{
  class Circle : Figure
  {
    double PI = 3.14;
    public double Radius { get; set; }

    public Circle(double radius)
    {
      Radius = radius;
    }

    public override double Area()
    {
      return PI * Radius * Radius;
    }
  }
}
