// GusMgr.cs
using System.Collections;

namespace _4_7_IEnumerable
{
  class GusMgr
  {
    public void Run()
    {
      int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      // 1. 전형적인 출력 방식
      System.Console.WriteLine($"1. 전형적인 출력 방식");
      for(int i = 0; i < intArray.Length; i++)
        System.Console.Write($"{intArray[i]} ");
      System.Console.WriteLine();

      // 2. IEnumerator를 통한 출력
      System.Console.WriteLine($"2. IEnumerator를 통한 출력");
      IEnumerator enumerator = intArray.GetEnumerator();
      while (enumerator.MoveNext())
      {
        System.Console.Write($"{enumerator.Current} ");
      }
      // 3. foreach를 통한 출력
      // > 위의 2번의 문법이 너무 길어 귀찮으니 편의성을 통해 foreach 구문을 정의해줬어요.
      // > 개발자가 아래와 같이 쉽게 적으면 compiler는 정확히 2번의 코드로 변환하죠.
      // > 즉, IEnumerable이 구현 되지 않은 객체는 foreach문을 사용 할 수 없죠.
      System.Console.WriteLine($"3. foreach를 통한 출력");
      foreach(int i in intArray)
        System.Console.Write($"{1} ");
      System.Console.WriteLine();

      // 4. 사용자 정의 클래스의 foreach 사용
      // > Array는 IEnumerable이 구현 되어 있기에 element가 사용자 정의 클래스여도 foreach를 사용할 수 있죠.
      Student[] st = new Student[] { (new Student("길동이", 27)), (new Student("동길이", 26)) };
      System.Console.WriteLine("4. 사용자 정의 클래스의 foreach 사용");
      foreach (Student s in st)
        System.Console.WriteLine(s);      
    }
  }
}
