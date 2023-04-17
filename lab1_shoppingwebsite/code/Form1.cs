using th01;

namespace shoppingwebsite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            //this.Hide();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void btn_ss_a14_Click(object sender, EventArgs e)
        {

        }

        private void btn_ip5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btn_xm_poco_c40_Click(object sender, EventArgs e)
        {

        }

        private void btn_ip14prm_Click(object sender, EventArgs e)
        {
            ip14prm_info info = new ip14prm_info();
            info.Show();
        }

        private void btn_ip14_Click(object sender, EventArgs e)
        {
            ip14 info = new ip14();
            info.Show();

        }

        private void btn_ss_s23ultra_Click(object sender, EventArgs e)
        {
            s23ultra info = new s23ultra();
            info.Show();
        }

        private void btn_ss_a04_Click(object sender, EventArgs e)
        {
            ss_a04 info = new ss_a04();
            info.Show();
        }

        private void btn_xm_redmi_a1_Click(object sender, EventArgs e)
        {
            xm_redmi_a1 info = new xm_redmi_a1();
            info.Show();
        }

        private void btn_dndk_Click(object sender, EventArgs e)
        {
            log_reg user = new log_reg();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log_reg user = new log_reg();
            user.panel_register.Visible = true;
            user.Show();
        }
    }
}