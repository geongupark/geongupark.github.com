// Student.cs
namespace _4_7_IEnumerable
{
  class Student
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public override string ToString()
    {
      return $"name : {Name}, age : {Age}";
    }
  }
}
