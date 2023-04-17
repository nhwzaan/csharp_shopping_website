using shoppingwebsite;

namespace th01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); //homepage
            //Application.Run(new Form2()); //cart
            Application.Run(new Form3()); //personal_and_buy_history
            //Application.Run(new Form4()); //order
            // Application.Run(new ip14prm_info());
            //Application.Run(new ip14());
            //Application.Run(new s23ultra());
            //Application.Run(new ss_a04());
            //Application.Run(new xm_redmi_a1());
            //Application.Run(new log_reg());
        }
    }
}