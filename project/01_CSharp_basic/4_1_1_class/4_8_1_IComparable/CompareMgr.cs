// CompareMgr.cs
using System;
using System.IO;

namespace _4_8_1_IComparable
{
  class CompareMgr
  {
    public void Run()
    {
      // 1. int Class는 이미 CompareTo가 구현되어 있죠.
      int[] intArray = new int[] { 5, 4, 2, 3, 1 };
      Array.Sort(intArray);
      foreach (int i in intArray)
        Console.Write($"{i} ");
      Console.WriteLine();

      // 2. Student Class는 사용자 정의 클래스니 ICompareable을 상속하여 CompareTo 메소드도 직접 구현해줘요.
      Student[] stuArray = new Student[] { new Student("길동", 90, 47), new Student("허준", 99, 30), new Student("구스", 100, 7) };
      Array.Sort(stuArray);
      foreach (Student s in stuArray)
        Console.WriteLine($"{s} ");

      // 3. IDisposable를 상속하면 Dispose() 메소드를 구현해야하죠.
      FileStream stream = new FileStream(@"d:\temp\aa.txt", FileMode.Open);
      // using문을 벗어 날 때 StreamReader 클래스 객체인 reader의 Dispose 메소드가 호출된다.
      // using문을 통해 객체 자원 해제를 하지 않는 실수를 방지 할 수 있다.
      using (StreamReader reader = new StreamReader(stream))
      {
        string buffer;
        while ((buffer = reader.ReadLine()) != null)
        {

        }
      }
    }
  }
  class Student : IComparable, IDisposable
  {
    public string Name { get; set; }
    public int Score { get; set; }
    public int Id { get; set; }
    StreamReader reader;
    public Student(string name, int score, int id)
    {
      Name = name;
      Score = score;
      Id = id;
    }
    public override string ToString()
    {
      return $"{Name}[{Id}][{Score}]";
    }
    public int CompareTo(object obj)
    {
      Student st = obj as Student;
      int ret = this.Name.CompareTo(st.Name);
      return ret;
    }

    private void aaa()
    {
      FileStream stream = new FileStream(@"d:\temp\aa.txt", FileMode.Open);
      reader = new StreamReader(stream);
      string buffer;
      while ((buffer = reader.ReadLine()) != null)
      { }
    }

    #region IDisposable 인터페이스 상속 후 Dispose() 메소드 구현 공식
    bool disposed; // false로 초기화
    ~Student()  // 소멸자 : 객체가 사라질 때 호출 됨.
    {
      Dispose(false);
    }
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
    public void Dispose(bool disposing)
    {
      if (disposed) return; // 이미 dispose 처리 했으면 return. 
      if (disposing)
      {
        // C#에서 사용하는 IDisposable을 구현한 객체들 정리
        reader.Close();
        reader.Dispose();
      }
      else
      {
        // .NET Framework에서 관리되지 않는 자원들 정리
      }
      disposed = true;
    }
    #endregion
  }
}
