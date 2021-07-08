using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfICacleivas.Models;

namespace WpfICacleivas.Controllers
{
    public class MainController
    {
        private MainWindow mainwindow;
        SaveFileDialog sfdialog;
        OpenFileDialog ofdialog;
        private List<string> producto = new List<string>();
        public MainController(MainWindow window)
        {
            mainwindow = window;
            sfdialog = new SaveFileDialog();
            ofdialog = new OpenFileDialog();

        }
        public void MainWindowEventHandler(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }
        public void MainMenuEventHandler(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "SaveButton":
                    Save();
                    break;
                case "OpenButton":
                    Open();
                    break;
                case "ClearButton":
                    mainwindow.limpiar();
                    break;
                case "AgregarButton":
                    mainwindow.agregar();
                    break;

            }
        }




        public void Save()
        {
          

            sfdialog.Filter = "Xml File (*.xml)|*.xml";
            if (sfdialog.ShowDialog() == true)
            {
                Pedido p
                    ;
                p = mainwindow.getdata();

                p.ToXml(sfdialog.FileName);
            }





        }
        private void Open()
        {

            ofdialog.Filter = "Xml File (*.xml)|*.xml";
            if (ofdialog.ShowDialog() == true)
            {
                Pedido p = new Pedido();
                mainwindow.SetData(p.FromXml(ofdialog.FileName));

            }
        }



    }
}
