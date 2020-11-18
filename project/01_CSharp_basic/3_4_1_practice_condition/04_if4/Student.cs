// 04_if4 > Student.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _04_if4
{
  class Student
  {
    public string Name { get; set; }
    public int Score { get; set; }
    public SexEnum Sex { get; set; }

    /// <summary>
    /// 주요 흐름은 "한줄코딩"으로 해야해요.
    /// 라이브러리를 구현 해놓고 가져다 쓰면 되죠!!
    /// </summary>
    public void ReadProperty()
    {
      Name = MyUtil.GetName();
      Score = MyUtil.GetDigit(0,100);
      Sex = MyUtil.GetSex();
    }
  }
}
