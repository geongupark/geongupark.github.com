// MenuItem.cs

namespace _4_12_2_console_with_delegate
{
  // 각 메뉴 한줄을 의미
  class MenuItem
  {
    public string MenuChar { get; set; }
    public string MenuTitle { get; set; }
    public delegate void MenuKeyPressDelegate(object sender, MenuArgs args);  // delegate 자료형 선언
    public MenuKeyPressDelegate KeyPressDelegate { get; set; }  // func(sender, args)

    public MenuItem(string menu_char, string menu_title, MenuKeyPressDelegate dele)
    {
      MenuChar = menu_char;
      MenuTitle = menu_title;
      KeyPressDelegate = dele;
    }
    public MenuItem() : this(null, null, null)
    {
    }
  }
}
