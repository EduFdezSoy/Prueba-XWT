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
            var mainWindow = new Window()
            {
                Title = "Xwt Demo Application",
                Width = 877,
                Height = 418
            };
            mainWindow.Show();
            Application.Run();
            mainWindow.Dispose();
        }
    }
}
