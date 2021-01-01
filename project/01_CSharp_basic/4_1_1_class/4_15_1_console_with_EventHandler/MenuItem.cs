// MenuItem.cs

using System;

namespace _4_15_1_console_with_EventHandler
{
  // 각 메뉴 한줄을 의미
  class MenuItem
  {
    public string MenuChar { get; set; }
    public string MenuTitle { get; set; }
    //public delegate void MenuKeyPressDelegate(object sender, MenuArgs args);  // delegate 자료형 선언
    //public MenuKeyPressDelegate KeyPressDelegate { get; set; }  // func(sender, args)
    public event EventHandler MenuKeyPressEventHandler; 

    //public MenuItem(string menu_char, string menu_title, MenuKeyPressDelegate dele)
    public MenuItem(string menu_char, string menu_title)
    {
      MenuChar = menu_char;
      MenuTitle = menu_title;
      //KeyPressDelegate = dele;
    }
    //public MenuItem() : this(null, null, null)
    public MenuItem() : this(null, null)
    {
    }
    public void CallEvent(object sender, string args)
    {
      if (MenuKeyPressEventHandler != null)
        MenuKeyPressEventHandler(sender, new MenuKeyPressArgs(args));
    }
  }
}

