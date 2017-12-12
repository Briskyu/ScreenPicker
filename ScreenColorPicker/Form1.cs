//Developed by Brisk v1.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static ScreenColorPicker.CWin32Api;

namespace ScreenColorPicker
{
    public partial class Form1 : Form
    {
        int MOUSEHOOK = 14; //鼠标钩子的ID
        CWin32Api.HookProc hookproc; //声明委托类型的变量
        int hookHandle; //保存钩子句柄

        int X;
        int Y;
        CWin32Api.MouseHookStruct mouseHookStruct;

        Bitmap desktopImage;
        Color color;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            hookproc = new CWin32Api.HookProc(MouseEvent);  //为委托变量赋值（方法名）
            hookHandle = CWin32Api.SetWindowsHookEx(MOUSEHOOK, hookproc, IntPtr.Zero, 0);   //安装钩子
        }

        //钩子函数
        private int MouseEvent(int nCode, IntPtr wParam, IntPtr lParam)
        {
            //将指针转换成结构体来获取其中的内容
            mouseHookStruct = (CWin32Api.MouseHookStruct)Marshal.PtrToStructure(lParam, typeof(CWin32Api.MouseHookStruct));
            X = mouseHookStruct.pt.x;
            Y = mouseHookStruct.pt.y;
            textBoxX.Text = X.ToString();
            textBoxY.Text = Y.ToString();
            if (X > 0 && Y > 0 && desktopImage != null)
            {
                color = desktopImage.GetPixel(X, Y);
                textBoxRGB.Text = "R:" + color.R + " G:" + color.G + " B:" + color.B;
                textBoxBrightness.Text= color.GetBrightness().ToString();
            }
            return 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //卸载钩子
            CWin32Api.UnhookWindowsHookEx(hookHandle);
        }

        //获取当前屏幕
        private void buttonFresh_Click(object sender, EventArgs e)
        {
            int iWidth = Screen.PrimaryScreen.Bounds.Width;
            int iHeight = Screen.PrimaryScreen.Bounds.Height;
            //按照屏幕宽高创建位图
            desktopImage = new Bitmap(iWidth, iHeight);
            //从一个继承自Image类的对象中创建Graphics对象
            Graphics g = Graphics.FromImage(desktopImage);
            //抓屏并拷贝到myimage里
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));  //前两个Point代表源矩形和目标矩形对应左上角的点
            g.Dispose();
        }
    }
}
