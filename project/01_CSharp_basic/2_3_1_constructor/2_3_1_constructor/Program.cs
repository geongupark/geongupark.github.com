/*

1. Student.cs 파일 및 Student class 생성
2. 기존 Program.cs 파일에 Student class 생성 → 동일 namespace 안에 같은 class가 2개 중복 정의되어버려 오류 발생함.
3. 그래서, Student.cs 파일의 namespace를 gus로 변경해준다. → 2번의 중복 오류 해결
4. _2_3_1_constructor.Student 클래스 위에 summary 써준다. gus.Student 클래스 위에도 summary 써준다.
5. Main method 내의 Student class 인스턴스 자료형에 커서를 맞추면 설명이 나오죠.
6. _2_3_1_constructor.Student 클래스의 생성자 생성 및 오버로딩을 했어요.
7. 이때, member 변수 초기화 시 다양한 case들에 대해 전부 코드를 작성하는게 아닌 생성자 재사용을 통해 맛깔스럽게 코드를 구성할 수 있어요.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_1_constructor
{
  class Program
  {
    static void Main(string[] args)
    {
      Student st1 = new Student();
      gus.Student st2 = new gus.Student();
      Student st3 = new Student("홍길동", "서울시");
      Student st4 = new Student("길동홍");

      st1.printName();
      st1.printAddress();
      st3.printName();
      st3.printAddress();
      st4.printName();
      st4.printAddress();
    }
  }

  /// <summary>
  /// <para>_2_3_1_constructor.Student 클래스 정의</para>
  /// <para>하하하!</para>
  /// </summary>
  public class Student
  {
    private string name;
    private string address;

    // signiture를 다르게 하니 생성자 메소드 오버로딩 가능함.
    // 생성자 내에서 생성자를 호출하여 맛깔나게 생성자 구현하기.
    public Student(string name, string address)
    {
      this.name = name;
      this.address = address;
    }
    public Student(string name) : this(name, null)
    {
    }

    public Student() : this(null)
    {
    }

    public void printName()
    {
      Console.WriteLine("이름 : " + this.name);
    }

    public void printAddress()
    {
      Console.WriteLine("주소 : " + this.address);
    }

  }
}
