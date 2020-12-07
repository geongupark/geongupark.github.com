// Program.cs
namespace _4_5_1_abstract
{
  class Program
  {
    static void Main(string[] args)
    {
      IFigure rect = new Rectangle(10, 20);
      IFigure cir = new Circle(5);

      PrintFigure(rect);
      PrintFigure(cir);
    }

    #region < Loosely coupling (느슨한 연결) >
    // figure 추가 되도 method가 늘어나지 않음.
    static void PrintFigure(IFigure fig)
    {
      Console.WriteLine($"{fig.GetType().FullName}의 면적 : {fig.Area()}");
    }
    #endregion

    #region < Tightly coupling (강력한 연결) >
    // figure 하나 씩 추가 할 때마다 Print method 하나 씩 증가함.
    static void PrintRect(Rectangle rec)
    {
      Console.WriteLine($"{rec.GetType().FullName}의 면적 : {rec.Area()}");
    }
    static void PrintCir(Circle cir)
    {
      Console.WriteLine($"{cir.GetType().FullName}의 면적 : {cir.Area()}");
    }
    // ...
    #endregion
  }
}
