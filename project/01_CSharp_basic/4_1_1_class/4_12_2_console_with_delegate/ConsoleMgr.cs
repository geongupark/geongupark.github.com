// ConsoleMgr.cs
using System;

namespace _4_12_2_console_with_delegate
{
  class ConsoleMgr
  {
    ConsoleMenu Menu;
    public ConsoleMgr()
    {
      Menu = new ConsoleMenu();
    }
    public void Run()
    {
      CreateMenu();
      for (; ; )
      {
        Menu.Show();
        Menu.Read();
      }
    }
    private void CreateMenu()
    {
      Menu.MenuList.Add(new MenuItem("1", "Menu_Title_1", Menu_1_Callback));
      Menu.MenuList.Add(new MenuItem("2", "Menu_Title_2", Menu_2_Callback));
      Menu.MenuList.Add(new MenuItem("q", "Exit", Quit_Callback));
    }
    private void Quit_Callback(object sender, MenuArgs args)
    {
      Console.WriteLine("Bye...");
      Environment.Exit(0);
    }
    private void Menu_1_Callback(object sender, MenuArgs args)
    {
      Console.WriteLine($"callback{((MenuKeyPressArgs)args).MenuChar}, sender = {sender.ToString()}");
    }
    private void Menu_2_Callback(object sender, MenuArgs args)
    {
      Console.WriteLine($"callback{((MenuKeyPressArgs)args).MenuChar}, sender = {sender.ToString()}");
    }
  }
}
