﻿using shoppingwebsite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th01
{
    public partial class xm_redmi_a1 : Form
    {
        public xm_redmi_a1()
        {
            InitializeComponent();
        }

        private void btn_back_to_homepage_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            //f1.Show();
            this.Close();
        }
    }
}
