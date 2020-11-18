/*
 * 4. Student 등록을 위한 method를 만들어줘요.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2_StudentManagement
{
  // program control을 위한 대빵 Class
  public class StudentMgr
  {
    // 대빵 class의 대표 method
    public void Run()
    {
      Student st = RegistStudent();
      st.PrintMe();
    }

    private Student RegistStudent()
    {
      Console.WriteLine("학년 [숫자만 입력] : ");
      String grade = Console.ReadLine();
      Console.WriteLine("반 : ");
      String stclass = Console.ReadLine();
      Console.WriteLine("번호 : ");
      String stnumber = Console.ReadLine();
      Console.WriteLine("이름 : ");
      String stname = Console.ReadLine();

      Student st = new Student(
        (Grade)Enum.Parse(typeof(Grade), grade),
        (StudentClass)Enum.Parse(typeof(StudentClass), stclass),
        Convert.ToInt32(stnumber),
        stname
      );
      return st;
    }
  }
}
