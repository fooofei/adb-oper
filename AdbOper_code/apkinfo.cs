using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

/*
 * Reference : http://www.sum16.com/desinger/c-sharp-read-package-name-by-aapt.html
 * 
*/
namespace AdbOper
{
    class ApkInfo
    {
        public ApkInfo()
        {
        }
       
        public String PackageName { get; set; }
        
        public String AaptPath
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "aapt.exe"); }
        }

        public void getApkInfo(String apkPath)
        {
            ProcessStartInfo pi = new ProcessStartInfo(AaptPath,
                String.Format("d badging \"{0}\"", apkPath))
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                };
            Process p = Process.Start(pi);
            StreamReader output = p.StandardOutput;
            string line = output.ReadLine();
            if (String.IsNullOrEmpty(line) || !line.StartsWith("package"))
            {
                return;
            }
            string[] arr = line.Split(new[] { ' ', '=', ':', '\'' }, StringSplitOptions.RemoveEmptyEntries);
            PackageName = arr[2];
        }
    }

    
}
