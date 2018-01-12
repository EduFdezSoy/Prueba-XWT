using System;
using Xwt;
using Xwt.Drawing;

namespace XWT_Prueba
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            Title = "Mi proyecto XWT";
            Height = 300;
            Width = 800;

            #region Menu
            //Crea un menú
            Menu mimenu = new Menu();

            //Añade al menu un boton Archivo con Subbotones
            MenuItem _archivo = new MenuItem("_Archivo");
            _archivo.SubMenu = new Menu();
            _archivo.SubMenu.Items.Add(new MenuItem("_Abrir"));
            _archivo.SubMenu.Items.Add(new MenuItem("_New"));

            //Crea el sub-boton cerrar dentro de archivo para darle un evento
            MenuItem _cerrar = new MenuItem("_Cerrar");

            //Evento al clickar en "cerrar"
            _cerrar.Clicked += _cerrar_Clicked;

            //Guarda el boton cerrar dentro de archivo
            _archivo.SubMenu.Items.Add(_cerrar);

            //Termina todo el primer boton
            mimenu.Items.Add(_archivo);

            MenuItem _editar = new MenuItem("_Editar");
            _editar.SubMenu = new Menu();
            _editar.SubMenu.Items.Add(new MenuItem("_Copiar"));
            _editar.SubMenu.Items.Add(new MenuItem("Co_rtar"));
            _editar.SubMenu.Items.Add(new MenuItem("_Pegar"));

            mimenu.Items.Add(_editar);

            MainMenu = mimenu;
            #endregion

            CloseRequested += MainWindow_CloseRequested;


        }

        private void _cerrar_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_CloseRequested(object sender, CloseRequestedEventArgs args)
        {
            args.AllowClose = MessageDialog.Confirm("Este programa se va a cerrar...\n¿Estas seguro?", Command.Ok);
            if (args.AllowClose)
                Application.Exit();
        }
    }
}