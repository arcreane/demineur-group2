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
            ElementsGrille tabBtn[][];
            tabBtn = new ElementsGrille[g.getLong()][];
            
            for ( i = 0; i < g.getLarg();i++) {
                RowDefinition temp = new RowDefinition();
                grilleJeu.RowDefinitions.Add(temp);
                if (i == 0)
                {
                    for ( j = 0; j < g.getLong(); j++)
                    {
                        ColumnDefinition tempBis = new ColumnDefinition();
                        grilleJeu.ColumnDefinitions.Add(tempBis);
                        Grid.SetRow(btn[][],i);
                        Grid.SetColumn(btn, j);

                    }
                }
            }
            
        }
            
    }
}
