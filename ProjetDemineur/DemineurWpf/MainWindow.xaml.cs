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
using ProjetDemineur;

namespace DemineurWpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int i, j;
            Grille g = new Grille();


            for (i = 0; i < g.getLong(); i++)
            {
                RowDefinition temp = new RowDefinition();
                grilleJeu.RowDefinitions.Add(temp);
               
                for (j = 0; j < g.getLarg(); j++)
                {
                    if (i == 0)
                    {
                        ColumnDefinition tempBis = new ColumnDefinition();
                        grilleJeu.ColumnDefinitions.Add(tempBis);
                    }
                    Button Btn = new Button();
                    Grid.SetRow(Btn, i);
                    Grid.SetColumn(Btn, j);
                    grilleJeu.Children.Add(Btn);
                    Btn.Click += clickCase;
                    Btn.Tag = g.getCase(i, j); 
                }



            }

        }

        private void clickCase(object sender, RoutedEventArgs e)
        {
            Button tempBtn = sender as Button;
            ElementsGrille elementClick = tempBtn.Tag as ElementsGrille;
            elementClick.decouvreCase();
            tempBtn.Content = elementClick.apparenceCase;
        }
    }
}
