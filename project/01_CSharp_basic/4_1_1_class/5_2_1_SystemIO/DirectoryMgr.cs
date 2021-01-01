// DirectoryMgr.cs
using System;
using System.IO;

namespace _5_2_1_SystemIO
{
  class DirectoryMgr
  {
    public void Run()
    {
      // Directory(=static class), DirectoryInfo(=Instance class)
      for (; ; )
      {
        TestDirectory();
      }
    }

    private void TestDirectory()
    {
      Console.Write("1. Directory 입력 : ");
      string root = Console.ReadLine();

      Console.Write("2. CMD 입력 : ");
      string cmd = Console.ReadLine();

      // CRUD : Create, Read, Update, Delete
      switch (cmd)
      {
        case "C":
          CreateDirectory(root);
          break;
        case "R":
          //ReadDirectory(root);
          ReadDirectory_Info(root);
          break;
        case "U":
          RenameDirectory(root, string.Concat(root, "_cp"));
          break;
        case "D":
          DeleteDirectory(root);
          break;
        case "Q":
          Environment.Exit(0);
          break;
        default:
          break;
      }
    }

    private void RenameDirectory(string root, string newName)
    {
      try
      {
        if (Directory.Exists(root))
          Directory.Move(root, newName);
      }
      catch (Exception e)
      {
        Console.WriteLine($"Error : {e.Message}");
      }
    }

    private void DeleteDirectory(string root)
    {
      try
      {
        if (Directory.Exists(root))
          Directory.Delete(root);
      }
      catch (Exception e)
      {
        Console.WriteLine($"Error : {e.Message}");
      }
    }

    private void CreateDirectory(string root)
    {
      if (!Directory.Exists(root))
      {
        Console.WriteLine($"{root} 경로가 존재하지 않습니다. 생성합니다.");
        Directory.CreateDirectory(root);
      }
      return;
    }
    private void ReadDirectory(string root)
    {
      if (Directory.Exists(root))
      {
        Console.WriteLine($"{root} 경로가 존재합니다.");
        string[] files = Directory.GetFiles(root);
        foreach (string file in files)
          Console.WriteLine($"[File] {file}을 찾았습니다.");

        string[] directories = Directory.GetDirectories(root);
        foreach (string dir in directories)
        {
          Console.WriteLine($"[Directory] {dir}을 찾았습니다.");
        }
      }
    }
    private void ReadDirectory_Info(string root)
    {
      DirectoryInfo di = new DirectoryInfo(root);
      // Path class Testing
      Console.WriteLine($"Path Test : {Path.Combine(root,"GusCombine")}");

      if (di.Exists)
      {
        Console.WriteLine($"{root} 경로가 존재합니다.");
        FileInfo[] files = di.GetFiles();
        foreach (FileInfo file in files)
          Console.WriteLine($"[File] {file.FullName}을 찾았습니다. 파일명 : {file.Name}, 확장자 : {file.Extension}");

        DirectoryInfo[] directories = di.GetDirectories();
        foreach (DirectoryInfo dir in directories)
        {
          Console.WriteLine($"[Directory] {dir.FullName}을 찾았습니다.");
        }
      }
    }

  }
}