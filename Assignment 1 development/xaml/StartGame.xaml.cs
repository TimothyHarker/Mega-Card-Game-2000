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

namespace Assignment_1_development
{
    /// <summary>
    /// Interaction logic for StartGame.xaml
    /// </summary>
    public partial class StartGame : Page
    {
        public StartGame()
        {
            InitializeComponent();
        }

        // Start Game Button Functionality
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CharacterSelectScreen characterSelectScren = new CharacterSelectScreen();
            this.NavigationService.Navigate(characterSelectScren);
        }

        // Close Game Button Functionality
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Window.Close();
        }
    }
}
