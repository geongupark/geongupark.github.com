using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

1. 2.3에서 다룬 Student class 코드(맛깔나는 생성자) 그대로 다시 구현해줬어요.
2. 전처리 지시문인 #region ~ #endregion으로 코드를 맛깔나게 정리할 수 있어요.
3. Student 내 멤버 변수가 private 이여도 밖에서 해당 멤버 변수 값을 읽고 쓸 수 있게 하는 방식이 getter, setter에요.
4. 왜 멤버 변수 자체를 public으로 쓰지 않고 이렇게 귀찮게 getter, setter로 쓸까요?
5. getter/setter는 잘못된 값이 멤버 변수에 들어가는 것을 검열하여 예외 처리를 할 수 있기 때문이죠!
6. property를 사용하면 getter/setter보다 더 우아하게 구현할 수 있어요.
7. 최근에는 private 멤버변수를 선언도 하지 않고 property를 변수처럼 사용하죠.

 */

namespace gus
{
  class Student
  {
    private string name;
    private string address;
    private int age;
    #region 생성자
    public Student(string name, string address)
    {
      this.name = name;
      this.address = address;
    }

    public Student(string name):this(name,null)
    {
    }

    public Student() : this(null)
    {
    }
    #endregion

    #region Getter/Setter

    public string GetName()
    {
      return name;
    }

    public void SetName(string name)
    {
      this.name = name;
    }

    public int GetAge()
    {
      return age;
    }

    public void SetAge(int age)
    {
      if (age < 0 || age > 121)
      {
        Console.WriteLine("나이는 음수나 120세를 넘을 수 없죠.");
        return;
      }
      this.age = age;
    }

    // *** property
    public string Address
    {
      get { return address; }
      set { address = value; }
    }

    // property를 이렇게 한줄로 쓸 수 도 있죠.
    // 이렇게 되면 굳이 height 멤버 변수를 사용하지 않고 Height property만 사용하면 되요.
    public double Height { get; set; }

    #endregion

    #region Method
    public void printName()
    {
      Console.WriteLine("Name : " + this.name);
    }
    public void printAddress()
    {
      Console.WriteLine("Address : " + this.address);
    }
    #endregion
  }
}
