/*
 * 1. Enum 형을 만들어줄 때는 public으로 만들어줘야해요. 모든 영역에서 볼 수 있어야 하기 때문이죠.
 * 2. Enum을 선언 할 때는 절대 약어로 쓰면 안되요. 이름만 보고 의미를 파악할 수 있어야 하기 때문이죠.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2_StudentManagement
{
  public enum Sex
  {
    Man, Woman, Invalid
  }

  public enum Grade
  {
    First = 1, Second, Third
  }

  public enum StudentClass
  {
    One = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Eleven, Twelve
  }
}
