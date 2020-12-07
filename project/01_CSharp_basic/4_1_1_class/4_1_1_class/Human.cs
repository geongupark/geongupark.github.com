// Human.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_1_class
{
  // Human class는 Animal class를 상속 받음.
  class Human : Animal
  {
    public string Name { get; set; }
    public string Address { get; set; }
    public string CellPhone { get; set; }

    public void Drawing() { }
    public void Study() { }
    public override void WhoAreYou()
    {
      Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + "I'm a Human");
    }
    public override string ToString()
    {
      return $"{base.ToString()} : 주소 = {Address}";
    }
  }
}
