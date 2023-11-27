using XIIRPL2_27_Ticketing.MasterForm;

namespace XIIRPL2_27_Ticketing
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
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.Show();
            //FrmMasterbandara bandara = new FrmMasterbandara();
            //bandara.Show();
            //FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
            //maskapai.Show();

           //FrmMasterKodePromo kodepromo = new FrmMasterKodePromo();
           //kodepromo.Show();

            FrmMasterJadwalPenerbangan jadwalPenerbanganan = new FrmMasterJadwalPenerbangan();
            jadwalPenerbanganan.Show();
            Application.Run();
        }
    }
}