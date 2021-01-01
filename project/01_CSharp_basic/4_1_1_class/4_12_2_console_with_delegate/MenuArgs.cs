// MenuArgs.cs
namespace _4_12_2_console_with_delegate
{
  class MenuArgs
  {
  }

  class MenuKeyPressArgs : MenuArgs
  {
    public string MenuChar { get; set; }
    public MenuKeyPressArgs(string menu_char)
    {
      MenuChar = menu_char;
    }
  }
}
