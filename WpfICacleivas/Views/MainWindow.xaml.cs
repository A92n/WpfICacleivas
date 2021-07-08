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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfICacleivas.Controllers;
using WpfICacleivas.Models;

namespace WpfICacleivas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainController mc;
        private List<string> producto = new List<string>();
        private int count = 0;
        public MainWindow() { 
      
            InitializeComponent();
            
            SetupController();
            listN.ItemsSource = producto;
        }

        public void SetupController()
        {
            mc = new MainController(this);
            RoutedEventHandler routed = new RoutedEventHandler(mc.MainMenuEventHandler);
            this.SaveButton.Click += routed;
            this.SelectButton.Click += routed;
            this.ClearButton.Click += routed;


        }
        public void agregar()
        {
          
          
            if (!string.IsNullOrWhiteSpace(ProductoComboBox.SelectedValue.ToString()) && !producto.Contains(ProductoComboBox.SelectedValue.ToString()))
                producto.Add(ProductoComboBox.SelectedValue.ToString());




        }

        public void limpiar()
        {
            NpedidoTextBox.Clear();
            NclienteTextBox.Clear();
            ProductoComboBox.Text = "";
            producto.Clear();


        }
        public Pedido getdata()
        {
            Pedido p = new Pedido
            { 
                
                pedido= count++,
                Ncliente=NclienteTextBox.Text,
                prod=producto

            

            };
            return p;



        }

        public void SetData(Pedido data)
        {
            NpedidoTextBox.DataContext = data;
            NclienteTextBox.DataContext = data;
            producto.AddRange(data.prod);
            listN.Items.Refresh();
         


        }



    }
}
