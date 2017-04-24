using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

// Reference : http://www.cnblogs.com/hnfxs/p/3192009.html
namespace AdbOper
{
    public partial class Form1 : CCWin.Skin_Mac
    {
       

        public Form1()
        {
            InitializeComponent();
            txtAdbLocation.Text = @"D:\eclipse_workspace\android-sdk-windows\platform-tools\adb.exe";
            //parseDevices( execCommand(null,"devices",null));
            ThreadPool.QueueUserWorkItem(new WaitCallback(execCommandThread),
                new Command(null,"devices",null,new ParseFunc(parseDevices)));

        }



        private void txtDragInstall_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            StringBuilder path = new StringBuilder(255);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".apk")
                {
                    GetShortPathName(file, path, path.Capacity);
                    //addResultToList( execCommand(listDevices.SelectedItems[0].Text,"install -r", path.ToString()));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(execCommandThread),
                new Command(listDevices.SelectedItems[0].Text, "install -r", path.ToString(),
                    new ParseFunc(addResultToList)));
                }
            }
        }

        private void txtDragInstall_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtDragUninstall_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtDragUninstall_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            ApkInfo apkinfo = new ApkInfo();
            StringBuilder path = new StringBuilder(255);
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".apk")
                {
                    GetShortPathName(file, path, path.Capacity);
                    apkinfo.getApkInfo(path.ToString());
                    //addResultToList( execCommand(listDevices.SelectedItems[0].Text,"uninstall", apkinfo.PackageName));
                    ThreadPool.QueueUserWorkItem(new WaitCallback(execCommandThread),
                new Command(listDevices.SelectedItems[0].Text, "uninstall", apkinfo.PackageName,
                    new ParseFunc(addResultToList)));
                }
            }
        }
        
        


        

        

        #region 解析设备函数，有与UI操作的部分
        /// <summary>
        /// 使用了异步的委托，当Worker线程调用这个函数的时候，就会走到if中
        /// if中的this.BeginInvoke,this指代了当前控件.第二次进入这个函数的时候
        /// 就跳过了if
        /// </summary>
        /// <param name="res"></param>
        private void parseDevices(String res)
        {
            if(this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new ParseFunc(parseDevices), res);
                }
                catch (Exception) { }
                
                return;
            }
            String separator = "\r\n";
            int index = res.IndexOf(separator);
            if (index == -1)
                return;
            // +4 for /r/n
            res = res.Substring(index + separator.Length);
            String[] devices = Regex.Split(res,"\r\n");
            listDevices.Items.Clear();//一定先清空 记住啊！！！
            foreach (String sdevice in devices)
            {
                if (null != Device(sdevice))
                {
                    listDevices.Items.Add(Device(sdevice));
                }
               
            }
            if(listDevices.Items.Count>0)
            {
                listDevices.Items[0].Selected = true;
                listDevices.Select();
            }
            
        }

        // as N880E/tdevice
        private String Device(String line)
        {
            if(line.Equals(""))
            {
                return null;
            }
            int index = line.LastIndexOf("\t");
            return line.Substring(0, index);
        }
        #endregion

        #region 添加字符串结果到历史列表中
        /// <summary>
        /// 添加字符串结果到历史列表中
        /// </summary>
        /// <param name="str">要添加的字符串,可以为空随便填</param>
        private void addResultToList(String str)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    this.Invoke(new ParseFunc(addResultToList), str);
                }
                catch (Exception) { }
                
                return;
            }
            if (!String.IsNullOrEmpty(str))
            {
               
                txtAdbHistory.SkinTxt.Text = DateTime.Now.ToString("HH:mm:ss") + " "
                    + str + txtAdbHistory.SkinTxt.Text;

            }
        }
        #endregion


        #region 点击前三个Button的事件
        private void btnReboot_Click(object sender, EventArgs e)
        {
            if(listDevices.SelectedItems.Count>0)
            {
                execCommand(listDevices.SelectedItems[0].Text, "reboot", null);
            }
            
        }

        private void btnRebootbootloader_Click(object sender, EventArgs e)
        {
            if (listDevices.SelectedItems.Count > 0)
            {
                execCommand(listDevices.SelectedItems[0].Text, "reboot bootloader", null);
            }
            
        }

        private void btnRebootRecovery_Click(object sender, EventArgs e)
        {
            if (listDevices.SelectedItems.Count > 0)
            {
                execCommand(listDevices.SelectedItems[0].Text, "reboot recovery", null);
            }
            
        }
        #endregion
       

        #region 用户点击Clean Button事件，清空历史，若历史本来是空的就刷新设备列表
        private void btnClean_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdbHistory.SkinTxt.Text))
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(execCommandThread),
                new Command(null, "devices", null, new ParseFunc(parseDevices)));
            }
            txtAdbHistory.SkinTxt.Text = "";
        }
        #endregion



        [DllImport("Kernel32.dll",CharSet = CharSet.Auto)]
        public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path,
                [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
                 int shortPathLength);

       
    }
}
