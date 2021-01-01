using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_1_Syste_String_practice
{
  class Program
  {
    static void Main(string[] args)
    {
      SamhapMgr shm = new SamhapMgr("자축인묘진사오미신유술해", new List<string> { "해묘미", "인오술", "사유축", "신자진" });
      shm.Run();
    }
  }
}
