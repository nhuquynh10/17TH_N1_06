﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  int hieuhaisoasdasdasdasdadasdsa(int a, int b){
            //modify from tonghaiso to hieuhaiso
            return a - b;
        }
        public bool login(string username, string password) {
            if (username == "adminnn" && password == "adminnnn") {
                return true;
            }
            return false;
        }

    }
}
