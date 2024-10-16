using DSOO_PI1_ComB_Grupo15_Paez_Fernandez;
using static System.Net.Mime.MediaTypeNames;


internal class Program
{
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        System.Windows.Forms.Application.Run(new Login());
    }
}