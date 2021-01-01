// ConsoleMenu.cs
using System;
using System.Collections.Generic;

namespace _4_15_1_console_with_EventHandler
{
  class ConsoleMenu
  {
    public List<MenuItem> MenuList { get; set; }
    public ConsoleMenu()
    {
      MenuList = new List<MenuItem>();
    }

    public void Show()
    {
      foreach (MenuItem item in MenuList)
        Console.WriteLine($"{item.MenuChar}. {item.MenuTitle}");
      Console.WriteLine();
    }

    public void Read()
    {
      Console.Write("choose menu >");
      string retVal = Console.ReadLine();
      foreach (MenuItem item in MenuList)
      {
        //if (item.MenuChar == retVal && item.KeyPressDelegate != null) // delegate 함수가 mapping 되어 있는지 여부 확인 하는 것 매우 중요함.
        //  item.KeyPressDelegate(this, new MenuKeyPressArgs(retVal));
        if (item.MenuChar == retVal)
          item.CallEvent(this, retVal); // EventHandler에 접근하려면 선언부에서 진행해야함.
      }
    }
  }
}
