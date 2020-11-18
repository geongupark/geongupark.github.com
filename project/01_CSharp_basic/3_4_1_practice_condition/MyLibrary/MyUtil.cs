// MyLibrary > MyUtil.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
  public class MyUtil
  {
    /// <summary>
    /// 콘솔로부터 0이상의 숫자를 받아들임
    /// <para>문자 입력시 -1 반환</para>
    /// <para>숫자 입력 시 int 형식으로 반환함</para>
    /// </summary>
    /// <returns></returns>
    static public int GetDigit()
    {
      Console.WriteLine("숫자를 입력하쇼[0~100] : ");
      return ConvertString2Int(Console.ReadLine());
    }

    /// <summary>
    /// 콘솔로부터 0이상의 숫자를 받아들임
    /// <para>문자 입력시 -1 반환</para>
    /// <para>숫자 입력 시 int 형식으로 반환함</para>
    /// <para>주어진 min, max 범위 내 숫자가 아니면 -2를 반환함</para>
    /// </summary>
    /// <returns></returns>
    static public int GetDigit(int min, int max)
    {
      Console.WriteLine("숫자를 입력하쇼[0~100] : ");
      int iret = ConvertString2Int(Console.ReadLine());
      if (iret < 0) return iret;
      if (iret > max || iret < min) return -2; // 범위 오버
      return iret;
    }

    /// <summary>
    /// String to int 변환 해줌
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    static public int ConvertString2Int(string str)
    {
      int result = 0;
      bool ret = int.TryParse(str, out result);
      if (ret)
        return result;
      else
        return -1;  // error
    }

    /// <summary>
    /// 성별을 받아들여 SexEnum 값으로 반환해주는 메소드
    /// </summary>
    /// <returns></returns>
    static public SexEnum GetSex()
    {
      Console.WriteLine("성별 입력[1:남성, 2:여성]");
      string sex = Console.ReadLine();
      int isex = ConvertString2Int(sex);
      if (isex == -1) return SexEnum.Error;
      else if (isex == 1) return SexEnum.Man;
      else if (isex == 2) return SexEnum.Woman;
      else return SexEnum.Error;
    }

    /// <summary>
    /// 이름 받는 메소드도 만들어줘요.
    /// </summary>
    /// <returns></returns>
    static public string GetName()
    {
      while (true)
      {
        Console.WriteLine("성명 입력: ");
        string name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
          return name;
      }
    }

    /// <summary>
    /// Error 표시 위한 메소드
    /// </summary>
    /// <param name="str"></param>
    static public void Err_Msg(string str)
    {
      Console.WriteLine(str);
    }

    /// <summary>
    /// 출력 위한 메소드
    /// </summary>
    /// <param name="str"></param>
    static public void Print_Msg(string str)
    {
      Console.WriteLine(str);
    }
  }
}
