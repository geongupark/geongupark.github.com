// Student.cs
using System;

namespace _5_4_1_System_Collection_ArrayList
{
  class Student : IComparable
  {
    public string Name { get; set; }
    public int StudentSex { get; set; }
    public int Score { get; set; }
    static public int SortStd = 0;
    public Student(string name, int sex, int score)
    {
      Name = name;
      StudentSex = sex;
      Score = score;
    }
    public Student() : this(null, 0, 0)
    {
    }
    public int CompareTo(object obj)
    {
      Student st = obj as Student;
      switch (SortStd)
      {
        case 0:
          return Name.CompareTo(st.Name);
          break;
        case 1:
          return Score.CompareTo(st.Score);
          break;
        default:
          break;
      }
      return Name.CompareTo(st.Name);
    }

    // ToString은 object class의 virtual method이기 때문에 override 가능하다.
    public override string ToString()
    {
      return $"{Name}[{StudentSex}][{Score}]";
    }
  }
}
