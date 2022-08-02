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

namespace PildorasInformaticas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<SuperHeroe> superHeroes = new List<SuperHeroe> {
                new SuperHeroe{Id=1,Name="Peter Parker",Alias="SpiderMan",Power="ability" },
                new SuperHeroe{Id=2,Name="Bruce Banner",Alias="Hulk",Power="super strong" },
                new SuperHeroe{Id=3,Name="Wade Wilson",Alias="DeadPool",Power="regeneration" }
            };
            superHeroes.Add(new SuperHeroe { Id = 4, Name = "Jane Grey", Alias = "Phonex", Power = "telekinesis" });

            listaSuperHeroes.ItemsSource = superHeroes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if( listaSuperHeroes.SelectedItem != null )
                MessageBox.Show((listaSuperHeroes.SelectedItem as SuperHeroe).Id.ToString());

        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Holi");
        }
    }

    public class SuperHeroe{
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Power { get; set; }

    }
}
