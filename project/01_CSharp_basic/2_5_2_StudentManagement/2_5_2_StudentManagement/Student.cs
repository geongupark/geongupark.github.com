/*
 * 1. 요구사항 기반으로 property를 만들어줘요.
 * 2. StGrade, StClass, StSex의 경우 Enum 자료형을 하나 만들어 정의해줬어요. 그러면 해당 요소를 write 할 때 넣는 값의 의미를 파악하기 쉬워져요.
 *    요소 이름으로만 넣을 값을 알기 어려운 경우, 이렇게 Enum을 통해 값의 의미를 설명해주면 되요.
 * 3. Name의 경우 Null이면 안되서 인스턴스 생성 시 값을 설정하도록 강요해야해요. 이러한 설정은 생성자를 통해 가능하죠.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2_StudentManagement
{
  class Student
  {
    #region 필드, 프로퍼티
    public Grade StGrade { get; set; }  // Primary key
    public StudentClass StClass { get; set; } // Primary key
    public int StNumber { get; set; } // Primary key
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Age { get; set; }
    public Sex StSex { get; set; } // Enum Sex 참조
    public decimal Mid1 { get; set; }
    public decimal Final1 { get; set; }
    public decimal Mid2 { get; set; }
    public decimal Final2 { get; set; }
    #endregion

    #region 생성자
    public Student(Grade grade, StudentClass stclass, int stnumber, string name, Sex stsex)
    {
      this.StGrade = grade;
      this.StClass = stclass;
      this.StNumber = stnumber;
      this.Name = name;
      this.StSex = stsex;
    }
    public Student(Grade grade, StudentClass stclass, int stnumber, string name)
      :this(grade, stclass, stnumber, name, Sex.Invalid)
    { 
    }
    #endregion

    #region Method
    public void PrintMe()
    {
      Console.WriteLine(StGrade + ":" + StClass + ":" + StNumber + "[" + Name + "]");
    }
    #endregion

  }
}
