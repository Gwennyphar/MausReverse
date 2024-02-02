﻿using System.Windows;
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bSwap"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]

        public static extern Int32 SwapMouseButton(Int32 bSwap);

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
        private void btnInfo_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("MausReverse\nVersion: 0.0.1\n(c) " + DateTime.Now.ToString("yy") + " Nico Anders", " " + DateTime.Now.ToString("yy"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown( );
        }

    }
}