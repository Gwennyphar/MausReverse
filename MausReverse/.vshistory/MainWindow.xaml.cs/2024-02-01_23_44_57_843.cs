using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;

namespace MausReverse {



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent( );
        }

        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        private void BtnLeft_Click(object sender, RoutedEventArgs e) {
            // Swap it.
            SwapMouseButton(1);
        }

      
    }
}