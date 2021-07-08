using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfICacleivas.Views;

namespace WpfICacleivas.Controllers
{
  public  class ConfiguracionController
    {
        private Configuracion config;
        SaveFileDialog sfdialog;
        OpenFileDialog ofdialog;
        private List<string> producto = new List<string>();
        public ConfiguracionController(Configuracion confi)
        {
            config = confi;
            sfdialog = new SaveFileDialog();
            ofdialog = new OpenFileDialog();

        }
       
        public void MenuEventHandler(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "SaveButton":
                   
                    break;
                case "OpenButton":
                   
                    break;
              
            }
        }











    }
}
