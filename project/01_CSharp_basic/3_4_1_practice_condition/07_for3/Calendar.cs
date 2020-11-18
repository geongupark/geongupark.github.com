// Calendar.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_for3
{
  class Calendar
  {
    // 1~12월 End date 필요 : 31, 30, 28
    int[] Month31 = new int[] { 1, 3, 5, 7, 8, 10, 12};
    int[] Month30 = new int[] { 4, 6, 9, 11};
    // member 변수를 통해 각 method가 공유하는 data를 처리
    // (줄바꿈, 각 달의 시작점 check를 위해 사용되는 변수)
    int CurrentDay = 0;

    public void PrintCalendar()
    {
      for (int i = 1; i < 13; i++)
      {
        PrintHeader(i);
        PrintMonth(i);
        PrintFooter();
      }
    }

    private void PrintHeader(int i)
    {
      Console.WriteLine($"{i}월");
      Console.WriteLine("------------------------------------");
      Console.WriteLine(string.Format("{0,-4}{1,-4}{2,-4}{3,-4}{4,-4}{5,-4}{6,-4}","일","월","화","수","목","금","토"));
    }
    private void PrintFooter()
    {
      Console.WriteLine();
      Console.WriteLine("------------------------------------");
      Console.WriteLine();
    }

    public void PrintMonth(int month)
    {
      int endDate;
      if (Month31.Contains(month)) endDate = 31;
      else if (Month30.Contains(month)) endDate = 30;
      else endDate = 28;

      PrintSpace();
      // month를 출력
      for (int i = 1; i <= endDate; i++)
        PrintDate(i);
    }

    private void PrintSpace()
    {
      for (int i = 0; i < CurrentDay; i++)
        Console.Write(string.Format("{0,-5}", ""));
    }

    public void PrintDate(int date)
    {
      Console.Write(string.Format("{0, -5}", date));
      CurrentDay++;
      if (CurrentDay == 7)
      {
        CurrentDay = 0;
        Console.WriteLine();
      }
    }
  }
}
