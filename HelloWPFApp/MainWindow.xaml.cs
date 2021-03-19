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

namespace HelloWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imieUtrataFocusu(object sender, RoutedEventArgs e)
        {
            labelKomunikat1.Content = ($"Witaj {textBoxImie.Text} {textBoxNazwisko.Text}");
        }

        private void nazwiskoUtrataFocusu(object sender, RoutedEventArgs e)
        {
            labelKomunikat1.Content = ($"Witaj {textBoxImie.Text} {textBoxNazwisko.Text}");
        }

        private void wiekUtrataFocusu(object sender, RoutedEventArgs e)
        {
            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if(wiek <= 0)
            {
                labelKomunikat2.Content = "Wprowadzono błędne dane"; 
            } 
            else if ( wiek < 67 )
            {
                int wiekOblicz = 67 - wiek;
                labelKomunikat2.Content = ($"Mając {wiek} lat, pozostało Ci {wiekOblicz} do emerytury");
            }
            else
            {
                labelKomunikat2.Content = "Jesteś na emeryturze";
            }
        }

        private void clickWyczysc(object sender, RoutedEventArgs e)
        {
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxWiek.Text = "";
            labelKomunikat1.Content = "";
            labelKomunikat2.Content = "";
        }
    }
}
