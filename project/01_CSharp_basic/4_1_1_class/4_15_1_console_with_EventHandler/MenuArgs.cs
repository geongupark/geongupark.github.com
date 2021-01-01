// MenuArgs.cs
using System;

namespace _4_15_1_console_with_EventHandler
{
  //class MenuArgs
  //{
  //}

  //class MenuKeyPressArgs : MenuArgs
  class MenuKeyPressArgs : EventArgs  // event handler 사용하니 EventArgs를 상속
  {
    public string MenuChar { get; set; }
    public MenuKeyPressArgs(string menu_char)
    {
      MenuChar = menu_char;
    }
  }
}
