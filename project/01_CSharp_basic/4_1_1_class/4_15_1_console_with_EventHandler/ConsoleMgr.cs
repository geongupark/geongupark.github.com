// ConsoleMgr.cs
using System;

namespace _4_15_1_console_with_EventHandler
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
      MenuItem item = new MenuItem("1", "Menu_Title_1");
      item.MenuKeyPressEventHandler += Menu_1_Callback;
      Menu.MenuList.Add(item);
      item = new MenuItem("2", "Menu_Title_2");
      item.MenuKeyPressEventHandler += Menu_2_Callback;
      Menu.MenuList.Add(item);
      item = new MenuItem("q", "Exit");
      item.MenuKeyPressEventHandler += Quit_Callback;
      Menu.MenuList.Add(item);
    }
    private void Quit_Callback(object sender, EventArgs args)
    {
      Console.WriteLine("Bye...");
      Environment.Exit(0);
    }
    private void Menu_1_Callback(object sender, EventArgs args)
    {
      Console.WriteLine($"callback{((MenuKeyPressArgs)args).MenuChar}, sender = {sender.ToString()}");
    }
    private void Menu_2_Callback(object sender, EventArgs args)
    {
      Console.WriteLine($"callback{((MenuKeyPressArgs)args).MenuChar}, sender = {sender.ToString()}");
    }
  }
}
