// 04_if4 > Scholarship.cs
using System;
using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_if4
{
  class Scholarship
  {
    public Student MyStudent { get; set; }

    #region 생성자
    public Scholarship(Student st)
    {
      MyStudent = st;
    }
    public Scholarship() : this(null) { }
    #endregion

    public void EvaluateScholarShip()
    {
      if (MyStudent == null)
      {
        MyUtil.Err_Msg("평가할 학생이 없어요.");
        return;
      }
      if (MyStudent.Sex == SexEnum.Error)
      {
        MyUtil.Err_Msg("성 구분이 틀렸어요");
      }
      if (MyStudent.Score == -2)
      {
        MyUtil.Err_Msg("성적이 범위를 벗어났어요");
        return;
      }
      if (MyStudent.Sex == SexEnum.Man)
      {
        if (MyStudent.Score > 90) MyUtil.Print_Msg("우수 장학생");
        else if (MyStudent.Score > 80) MyUtil.Print_Msg("장학생");
        else MyUtil.Print_Msg("해당사항 없음");
      }
      else
      {
        if (MyStudent.Score > 90) MyUtil.Print_Msg("해외연수 장학생");
        else if (MyStudent.Score > 80) MyUtil.Print_Msg("국비 장학생");
        else MyUtil.Print_Msg("해당사항 없음");
      }

    }
  }
}
