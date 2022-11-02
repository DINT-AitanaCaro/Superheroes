using Superheroes.Modelo;
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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nSuperhero = 0;
        List<Superheroe> superheroes = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();
            superheroeGrid.DataContext = superheroes[nSuperhero];
        }

        private void arrowImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = ((Image)sender);
            if (((Image)sender).Tag.ToString() == "+")
            {
                if (nSuperhero + 1 < 3) nSuperhero++;
            }
            else
            {
                if (nSuperhero - 1 > -1) nSuperhero--;
            }
            superheroeGrid.DataContext = superheroes[nSuperhero];
            superheroeNumberTextBlock.Text = $"{nSuperhero + 1}/3";
        }
    }
}
