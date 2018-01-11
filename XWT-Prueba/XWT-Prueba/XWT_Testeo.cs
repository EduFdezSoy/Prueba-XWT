using System;
using Xwt;



namespace XWT_Prueba
{
    class XWT_Testeo
    {
        [STAThread]
        static void Main()
        {
            Application.Initialize(ToolkitType.Gtk);
            MainWindow ventanaPrincipal = new MainWindow();
           
            ventanaPrincipal.Show();
            Application.Run();
            ventanaPrincipal.Dispose();
        }
    }
}
