﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MapController
{
    public partial class Form1 : Form
    {
        GEngine gEngine;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Starts when the Form i Loaded
            gEngine = new GEngine(this);
           // AllocConsole();

            this.Show();
            this.Focus();
            gEngine.LoadLevel();
            gEngine.Init();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Detect KeyDown
            gEngine.Press(e);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Detect KeyUp
            gEngine.NoPress(e);
        }

        //Console Window to Debug 
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
