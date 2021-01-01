// Student.cs
/// <summary>
/// txt파일 데이터 담을 자료구조
/// 핵심은 자료구조의 내용을 ToString을 통해 출력해준다는 것이다. (override)
/// </summary>
namespace _5_3_1_Stream
{
  class Student
  {
    public string Name { get; set; }
    public Sex StudentSex { get; set; }
    public int Score { get; set; }

    // ToString은 object class의 virtual method이기 때문에 override 가능하다.
    public override string ToString()
    {
      return $"{Name}[{StudentSex}][{Score}]";
    }
  }
}
