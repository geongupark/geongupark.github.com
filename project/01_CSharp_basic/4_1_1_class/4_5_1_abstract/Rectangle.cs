// Rectangle.cs
namespace _4_5_1_abstract
{
  class Rectangle : Figure
  {
    double x1, y1; // |x2 - x1| = width
    double x2, y2; // |y2 - y1| = height
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
      Width = width;
      Height = height;
    }
    public override double Area()
    {
      return (Width * Height);
    }
  }
}
