// StreamMgr.cs
using System;
using System.IO;
using System.Text;

namespace _5_3_1_Stream
{
  class StreamMgr
  {
    Student[] students = new Student[3];
    public void Run()
    {
      ReadStudent();
      PrintStudent();
      WriteStudent();
    }

    private void WriteStudent()
    {
      FileStream stream = new FileStream(@"D:\gustest\student.bak", FileMode.Create);
      StreamWriter writer = new StreamWriter(stream, UTF8Encoding.UTF8);

      foreach (Student st in students)
        writer.WriteLine($"{st.Name}#{st.StudentSex}#{st.Score}");
      writer.Close();
    }

    private void PrintStudent()
    {
      for (int i = 0; i < 3; i++)
        Console.WriteLine(students[i]);
    }

    private void ReadStudent()
    {
      FileStream stream = new FileStream(@"D:\gustest\student.txt", FileMode.Open);
      StreamReader reader = new StreamReader(stream, UTF8Encoding.UTF8);
      string buffer = null;
      int index = 0;

      while ((buffer = reader.ReadLine()) != null)
        InsertStudent(buffer, index++);
      reader.Close();
    }

    /// <summary>
    /// Text 파일 내용에 문제가 있는지 확인하는 방법 주목!
    /// </summary>
    /// <param name="buffer"></param>
    /// <param name="index"></param>
    private void InsertStudent(string buffer, int index)
    {
      Student st = new Student();
      string[] tmp = buffer.Split('#');
      if (tmp.Length != 3)
        throw new Exception("텍스트 내용에 오류가 있어요 : " + buffer);

      st.Name = tmp[0];
      st.Score = Convert.ToInt32(tmp[2]);
      st.StudentSex = (Sex)Enum.ToObject(typeof(Sex), int.Parse(tmp[1]));
      students[index] = st;
    }

  }
}
