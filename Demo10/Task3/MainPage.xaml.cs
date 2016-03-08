using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Task3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Lotto lotto;
        private string peli;
        private int rivit;

        public MainPage()
        {
            this.InitializeComponent();
            lotto = new Lotto();
        }      

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            int riviMaara;
            bool result = int.TryParse(textBox.Text, out riviMaara);
            if (result)
            {
                rivit = riviMaara;
            }

            else
            {
                rivit = 0;
            }

            string arvotturivi = "";

            for (int i = 1; i <= rivit; i++)
            {
                List<int> numerot = lotto.arvotutNumerot(peli);
                arvotturivi += "Rivi " + i + ": ";

                for (int j = 0; j < numerot.Count; j++)
                {
                    arvotturivi += numerot[j] + " ";
                }
                arvotturivi += " \n";
            }

            textBlock3.Text = arvotturivi;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            peli = comboBox.SelectedValue.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock3.Text = "";
        }

    }
}
