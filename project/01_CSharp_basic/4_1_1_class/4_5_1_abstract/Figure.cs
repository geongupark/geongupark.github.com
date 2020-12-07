// Figure.cs
namespace _4_5_1_abstract
{
  abstract class Figure : IFigure
  {
    // rectangular : width, height
    // Circle : radius, phi
    abstract public double Area();

    public override string ToString()
    {
      return base.ToString();
    }
  }
}
