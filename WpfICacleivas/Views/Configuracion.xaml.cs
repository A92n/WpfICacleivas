using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfICacleivas.Controllers;
using WpfICacleivas.Models;

namespace WpfICacleivas.Views
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        ConfiguracionController conf;

        public Configuracion()
        {
            InitializeComponent();
            SetupController();
        }

        public void SetupController()
        {
            conf = new ConfiguracionController(this);
            RoutedEventHandler routed = new RoutedEventHandler(conf.MenuEventHandler);
            this.AceptarButton.Click += routed;
            this.CancelarButton.Click += routed;
          


        }
        public Usuario getdata()
        {
           Usuario g = new Usuario
            {
                Names =NombreTextBox.Text,
                Correo=CorreoTextBox.Text


            };
            return g;



        }

        public void SetData(Usuario d)
        {
            NombreTextBox.DataContext = d;
            CorreoTextBox.DataContext = d;

        }



    }
}
