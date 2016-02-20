using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
namespace ExternalMDIChild
{
    public partial class ExternalWindowForm : Form
    {
        public ExternalWindowForm()
        {
            InitializeComponent();
        }
        //External refernce to user32.dll to set the parent property of an external window

        [DllImport("user32")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);


        private void NotepadMenuButton_Click(object sender, EventArgs e)
        {
            StartWindowedProcess("notepad.exe");
        }
        private void StartWindowedProcess(String process_name)
        {
            //Declare a new process
            var proc = new Process
            {
                //Define initial process info
                StartInfo = new ProcessStartInfo
                {
                    FileName = process_name
                }
            };
            //Start the process
            proc.Start();
            //Wait for the process to fully start so the MainWindowHandle can be determined
            proc.WaitForInputIdle();
            Thread.Sleep(500);
            //Using the MainWindowHandle property, set the window's parent to the WindowContainer panel
            SetParent(proc.MainWindowHandle, this.WindowContainer.Handle);
        }

        private void ExitMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculatorMenuButton_Click(object sender, EventArgs e)
        {
            StartWindowedProcess("calc.exe");
        }

        private void CommandLineMenuButton_Click(object sender, EventArgs e)
        {
            StartWindowedProcess("mspaint.exe");
        }
    }
}
