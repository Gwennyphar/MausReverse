using System.Windows;
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
        private void BtnRight_Click(object sender, RoutedEventArgs e) {
            // Swap it.
            SwapMouseButton(0);
        }

      
    }
}