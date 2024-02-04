using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Controls;

namespace MausReverse {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        /// <summary>
        /// Controller
        /// </summary>
        public MainWindow() {
            InitializeComponent();
            Title = "MausReverse V.0.0.1";
            string sTaste = AktiveMaustasteAbfragen();
            Maustaste.SelectedValue = sTaste.ToString();
            Ausgabe(sTaste);
        }

        /// <summary>
        /// Libary fuer Maustreiber einbinden
        /// </summary>
        /// <param name="fSwap"></param>
        /// <returns></returns>
        [LibraryImport("user32.dll")]

        private static partial Int32 SwapMouseButton(Int32 fSwap);

        /// <summary>
        /// returnanweisung fuer Textausgabe
        /// </summary>
        /// <param name="sTaste"></param>
        /// <returns></returns>
        public string Ausgabe(string sTaste) {
            return (string)(Mausanzeige.Content = "Primäre Maustaste " + sTaste);
        }

        /// <summary>
        /// vor dem Umstellen wird die aktive Maustaste vom System abgefragt,
        /// damit der Benutzer sieht, welche Taste die "linke" Taste ist.
        /// Und es wird ein entsprechender Hinweis angezeigt.
        /// </summary>
        /// <returns></returns>
        private static string AktiveMaustasteAbfragen() {
            string iTaste = SystemParameters.SwapButtons.ToString();
            string sTaste = iTaste.ToString();
            if (SystemParameters.SwapButtons == false) {
                sTaste = Maustasten().ElementAt(0);
            } else if (SystemParameters.SwapButtons == true) {
                sTaste = Maustasten().ElementAt(1);
            }
            return sTaste;
        }

        /// <summary>
        /// gibt Text fuer die aktive primaere Maustaste aus
        /// Vergleicht Text im Array mit dem Text in der Combobox und setzt das ausgewaehlte Element als aktiv
        /// </summary>
        /// <returns></returns>
        private static string[] Maustasten() {
            string[] strArr = {
                "Links",
                "Rechts"
            };
            return strArr;
        }

        /// <summary>
        /// 0 = setzt linke Maustaste als aktiv (default)
        /// 1 = tauscht rechte Maustaste als aktive linke Maustaste
        /// Holt Beschreibung aus dem Array Maustasten()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Maustaste_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int iAuswahl = Maustaste.SelectedIndex;
            string sTaste = "";
            if (iAuswahl == 0) {
                SwapMouseButton(0);
                sTaste = Maustasten().ElementAt(0);
            } else if(iAuswahl == 1) {
                SwapMouseButton(1);
                sTaste = Maustasten().ElementAt(1);
            }
            Ausgabe(sTaste);
        }

        /// <summary>
        /// oeffnet ein Infofenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("MausReverse\nVersion: 0.0.1\n(c) " + DateTime.Now.ToString("yyy") + " Nico Anders", "MausReverse");
        }

        /// <summary>
        /// app beenden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown( );
        }
    }
}