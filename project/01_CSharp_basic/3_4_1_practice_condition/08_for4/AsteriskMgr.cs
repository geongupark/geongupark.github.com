// AsteriskMgr.cs
using System;

namespace _08_for4
{
  class AsteriskMgr
  {
    public void Run()
    {
      bool isContinue = true;
      while (isContinue)
      {
        int mode = GetMode();
        int lines = GetLines();
        switch (mode)
        {
          case 1:
            PrintMode1(lines);
            break;
          case 2:
            PrintMode2(lines);
            break;
          case 3:
            PrintMode3(lines);
            break;
          case 4:
            PrintMode4(lines);
            break;
          default:
            isContinue = false;
            break;
        }
      }
      PrintExit();
    }

    private int GetMode()
    {
      int result;
      do
      {
        Console.Write("Enter Mode [1~4 : mode, others : exit] > ");
      } while (!int.TryParse(Console.ReadLine(), out result));

      return result;
    }

    private int GetLines()
    {
      int result;
      do
      {
        Console.Write("Enter Lines > ");
      } while (!int.TryParse(Console.ReadLine(), out result));

      return result;
    }

    private void PrintMode1(int lines)
    {
      for (int i = 1; i <= lines; i++)
        PrintAsterisk(" ", 0, "*", i);
    }

    private void PrintMode2(int lines)
    {
      for (int i = lines; i >= 1; i--)
        PrintAsterisk(" ", 0, "*", i);
    }
    private void PrintMode3(int lines)
    {
      for (int i = 1; i <= lines; i++)
        PrintAsterisk(" ", lines - i, "*", i);
    }

    private void PrintMode4(int lines)
    {
      for (int i = 1; i <= lines; i++)
        PrintAsterisk(" ", lines - i, "*", 2 * i - 1);
    }

    private void PrintAsterisk(string first, int fCnt, string second, int sCnt)
    {
      PrintCharacters(first, fCnt);
      PrintCharacters(second, sCnt);
      Console.WriteLine();
    }

    private void PrintCharacters(string characters, int loopCnt)
    {
      for (int i = 0; i < loopCnt; i++)
        Console.Write(characters);
    }

    private void PrintExit()
    {
      Console.WriteLine("Exit the Program...");
    }
  }
}
