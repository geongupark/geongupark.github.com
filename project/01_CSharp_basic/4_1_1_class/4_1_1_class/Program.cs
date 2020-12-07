// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_1_class
{
  class Program
  {
    static void Main(string[] args)
    {
      //practice_4_2();
      //practice_4_3();
      practice_4_4();
    }

    private static void practice_4_4()
    {
      Student sd = new Student();
      sd.Grade = 4;
      sd.Address = "병점이";
      Console.WriteLine(sd);
    }

    private static void practice_4_3()
    {
      Animal am = new Animal();
      am.WhoAreYou();
      Human hm = new Human();
      hm.WhoAreYou();
      Student sd = new Student();
      sd.WhoAreYou();

      Animal ast = new Student();
      ast.WhoAreYou();
    }

    static public void practice_4_2()
    {
      // [precondition]
      // Student class는 Human class 상속
      // Human class는 Animal class 상속

      Student st1 = new Student(); // 가능
      Human h1 = new Student(); // 가능 : 단, h1은 Human의 property와 method만 가져요.
      Human h2 = new Human();
      //Student st2 = h1; // 불가능 :
      Student st2 = h1 as Student; // 가능
      //Student st3 = (Student)h2; // 불가능 : 문법적으로는 하자 없으나 runtime 수행 시 error 발생

      // is
      Animal ani1 = new Animal();
      bool ret1 = st2 is Human; // ret1 : true
      bool ret2 = st2 is Student; // ret2 : true
      bool ret3 = st2 is Animal;  // ret3 : true
      bool ret4 = ani1 is Student;  // ret4 : false

      //Object
      Human h3 = new Human();
      Type type = h3.GetType();
      Console.WriteLine(type.FullName);  // _4_1_1_class.Human 출력!

      Human h4 = new Human();
      bool ret5 = h3.Equals(h4);  // false, object.Equals() 메소드 사용 됨.

      string str1 = "hello";
      string str2 = "hello";
      bool ret6 = str1.Equals(str2);  // true, string class에서 Equals 메소드를 오버로딩 함. string이 매개변수로 들어오는 경우.
      bool ret7 = str1.Equals(h3);    // false, Object.Equals method를 오버라이딩 함.
    }
  }
}
