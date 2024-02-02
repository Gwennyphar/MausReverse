using System.Windows;
using System.Runtime.InteropServices;

namespace MausReverse {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        /// <summary>
        /// 
        /// </summary>
        public MainWindow() {
            InitializeComponent( );
            Title = "MausReverse V.0.0.1";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bSwap"></param>
        /// <returns></returns>
        [LibraryImport("user32.dll")]

        private static partial Int32 SwapMouseButton(Int32 bSwap);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLeft_Click(object sender, RoutedEventArgs e) {
            // Swap it.
            SwapMouseButton(1);
        }
        private void BtnRight_Click(object sender, RoutedEventArgs e) {
            // Swap it.
            SwapMouseButton(0);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfo_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("MausReverse\nVersion: 0.0.1\n(c) " + DateTime.Now.ToString("yyy") + " Nico Anders", " " + "MausReverse");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown( );
        }

        private void RadioButtonLeft_Checked(object sender, RoutedEventArgs e) {

        }
        private void RadioButtonRight_Checked(object sender, RoutedEventArgs e) {

        }
    }
}