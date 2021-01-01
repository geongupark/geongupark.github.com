// UserString.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_1_1_Syste_String_practice
{
  class UserString
  {
    public string InputString { get; set; }
    public string AllChar { get; set; }
    List<string> Samhap;
    List<int> SolutionsBit;
    public UserString(string AllChar, List<string> Samhap)
    {
      this.AllChar = AllChar;
      this.Samhap = Samhap;
      SolutionsBit = new List<int>();
      foreach (string str in Samhap)
        SolutionsBit.Add(0);
    }

    public void PreCond()
    {
      initSolutionBit();
      getUserString();
    }
    public void Execution()
    {
      foreach (char ch in InputString)
        CheckSamhap(ch);
    }
    public void Result()
    {
      Console.WriteLine($"[Result]");
      GetResult();
      Console.WriteLine();
    }

    private void initSolutionBit()
    {
      int len = SolutionsBit.Count();
      for (int i = 0; i < len; i++)
        SolutionsBit[i] = 0;
    }
    private void getUserString()
    {
      bool bPass;
      string retVal;

      for (; ; )
      {
        bPass = true;

        Console.WriteLine($"Q. [{AllChar}] 중 6글자 입력 하세요.");
        Console.Write("user> ");
        retVal = Console.ReadLine();

        if (retVal.Length != 6)
          continue;

        foreach (char ch in retVal)
        {
          if (!AllChar.Contains(ch))
          {
            bPass = false;
            break;
          }
        }

        if (bPass)
        {
          InputString = retVal;
          break;
        }
      }
    }
    private void CheckSamhap(char ch)
    {
      int len = Samhap.Count();
      int idx = -1;

      for (int i = 0; i < len; i++)
      {
        idx = Samhap[i].IndexOf(ch);
        if (idx == -1)
          continue;
        SolutionsBit[i] |= 1 << idx;
      }
    }
    private void GetResult()
    {
      bool bSamhap = false;
      int len = SolutionsBit.Count();
      for (int i = 0; i < len; i++)
      {
        if(SolutionsBit[i] == 7)
        {
          bSamhap = true;
          Console.WriteLine($"삼합으로 \"{Samhap[i]}\"가 존재합니다.");
        }
      }
      if (bSamhap == false)
        Console.WriteLine($"삼합이 존재하지 않습니다.");
    }
  }
}
