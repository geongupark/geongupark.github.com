// 1-3-1 class 예제
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1. 새 Project 생성 후 기존 생성 되어 있던 App.config, Program.cs를 삭제해요.
/// 2. Project에 HelloWorld class를 추가해줘요.
/// 3. EXE 파일을 만들기 위해 하나의 main method는 존재해야해요.
/// </summary>

namespace _1_3_1_example_class
{
  class HelloWorld
  {
    static void Main()
    {
      // CTRL + "." 을 통해 해당되는 library가 무엇인지 찾을 수 있어요.
      System.Console.WriteLine("Hello World");
    }
  }
}