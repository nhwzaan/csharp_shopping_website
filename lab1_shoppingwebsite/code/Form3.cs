using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingwebsite
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_user_info_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Visible = true;
            //panel_buy_history.Visible = false;
        }

        private void btn_user_info2_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Visible = true;
            //panel_buy_history.Visible = false;
        }

        private void btn_buy_history_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Visible = true;
            //panel_buy_history.Visible = true;
        }

        private void btn_buy_history_2_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Visible = true;
            //panel_buy_history.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_info_Click_1(object sender, EventArgs e)
        {
            panel_history.Visible = false;
        }

        private void btn_buy_history_Click_1(object sender, EventArgs e)
        {
            panel_history.Visible = true;

        }
    }
}
