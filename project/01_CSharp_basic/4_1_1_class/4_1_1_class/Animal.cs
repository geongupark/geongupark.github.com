// Animal.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_1_class
{
  class Animal
  {
    public int Age { get; set; }
    public int  Sex { get; set; } // 0 : man, 1 : woman (원래 enum으로 해줘야 깔끔함)
    public int Weight { get; set; }

    public void Sleep() { }
    public void Eat() { }
    public void Walk() { }
    virtual public void WhoAreYou()
    {
      Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + "I'm an Animal");
    }
    public override string ToString()
    {
      return $"I'm a Animal : ";
    }
  }
}
