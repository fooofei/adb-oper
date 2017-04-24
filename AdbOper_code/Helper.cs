
using System;
using System.Text;
using System.Diagnostics;
using System.IO;

///
/// Form1 窗体的 帮助部分  与 UI无关的
///
namespace AdbOper
{
  public partial class Form1
  {

      public delegate void ParseFunc(String s);
      public class Command
      {
          public Command(String device, String cmd, String apkPath,
              ParseFunc parse)
          {
              Device = device;
              Cmd = cmd;
              ApkPath = apkPath;
              Parse = parse;
          }
          public String Device { get; set; }
          public String Cmd { get; set; }
          public String ApkPath { get; set; }
          public ParseFunc Parse { get; set; }

      }

      /// <summary>
      /// 执行命令线程
      /// </summary>
      /// <param name="o"></param>
      public void execCommandThread(object o)
      {
          Command cmdObj = (Command)o;
          cmdObj.Parse(execCommand(cmdObj.Device, cmdObj.Cmd, cmdObj.ApkPath));
      }

      public String getAdbLocation()
      {

          String adbLocation = txtAdbLocation.Text;
          if (String.IsNullOrEmpty(adbLocation) || !File.Exists(adbLocation))
          {
              adbLocation = "adb.exe";
          }
          else if (adbLocation.IndexOf("adb.exe") == -1)
          {
              adbLocation += Path.DirectorySeparatorChar + "adb.exe";
          }
          StringBuilder sb = new StringBuilder(255);
          GetShortPathName(adbLocation, sb, sb.Capacity);
          return sb.ToString();
      }

      /// <summary>
      /// 执行命令
      /// </summary>
      /// <param name="cmd">adb 的命令</param>
      /// <param name="filePath">安装程序的路径(不能有空格)</param>
      public String execCommand(String device, String cmd, String apkPath)
      {
          Process p = new Process();
          p.StartInfo.UseShellExecute = false;
          p.StartInfo.CreateNoWindow = true;
          p.StartInfo.FileName = "CMD.exe";
          if (String.IsNullOrEmpty(device))
              p.StartInfo.Arguments = "/c " + getAdbLocation() + " "
              + cmd + " " + apkPath;
          else
              p.StartInfo.Arguments = "/c " + getAdbLocation() + " -s " + device + " "
              + cmd + " " + apkPath;
          p.StartInfo.RedirectStandardError = true;
          p.StartInfo.RedirectStandardInput = true;
          p.StartInfo.RedirectStandardOutput = true;
          String res = null;
          try
          {
              p.Start();
              p.WaitForExit();
              res = p.StandardOutput.ReadToEnd();
          }
          finally
          {
              p.Close();
              p.Dispose();
          }
          return res;
      }


     
  }
}