// 04_if4 > IfMgr.cs
/*
 * 1. Project (= 04_if4) 생성, MyLibrary 참조 추가, 시작 프로젝트 설정, IfMgr.cs 생성
 * 2. MyLibrary에 Enum class 생성 및 남성, 여성 값 할당
 * 3. 04_if4 프로젝트에 Scholarship.cs, Student.cs 생성
 * 4. Scholarship.cs의 틀을 짜줘요.(property[ = prop + tab+ tab], 생성자, method)
 * 5. Student.cs의 틀을 짜줘요.(property[ = prop + tab+ tab], 생성자, method) 
 * 6. Student.cs의 ReadProperty() 메소드 구현에 필요한 API를 MyLibrary>MyUtil.cs에 만들어줘요. (for 한줄코딩)
 * 7. Error message 표시를 위한 API를 MyUtil.cs에 만들어줘요.
 * 8. 상위(=Run())로 갈 수록 의미 있는 단어(=method)들로 구성되요. syntax들은 모두 라이브러리 API에 감춰지죠.
 * 9. 여기서 배울 점은 상위 제어 흐름은 의미 있는 단어(=API)들로 글을 쓰듯이 구성하고 syntax들은 모두 라이브러리 API에 감춰진다는 사실이에요.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_if4
{
  class IfMgr
  {
    public void Run()
    {
      // 주 실행 흐름
      Student st = new Student();
      st.ReadProperty();

      Scholarship scholar = new Scholarship(st);
      scholar.EvaluateScholarShip();
    }
  }
}
