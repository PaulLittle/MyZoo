using System;
using System.Collections;
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

namespace MyZoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList zoo = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Animal animalOne = new Animal();
            Animal animalTwo = new Animal("Dumbo");
            Animal animalThree = new Animal("Champion", Gender.M);
            Animal animalFour = new Animal("Simba", Gender.M);
            zoo.Add(animalOne);
            zoo.Add(animalTwo);
            zoo.Add(animalThree);
            zoo.Add(animalFour);*/

            PopulateZoo();
            PopulateListbox();          
        }
        
        private void PopulateZoo()
        {
            zoo = new ArrayList()
            {
                new Animal { Name = "Dumbo" },
                new Animal { Name = "Champion", Sex = Gender.F },
                new Animal { Name = "Simba", Sex = Gender.M },
                new Animal()
            };
        }

        private void PopulateListbox()
        {
            foreach (var animal in zoo)
            {
                lbxAnimals.Items.Add(animal);
            }
        }

        private void lbxAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Notice.Text = (lbxAnimals.SelectedIndex >= 0)?
                (lbxAnimals.SelectedItem as Animal).Name:"Nothing Selected";
        }
    }
}
