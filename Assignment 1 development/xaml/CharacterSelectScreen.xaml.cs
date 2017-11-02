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
    /// Interaction logic for CharacterSelectScreen.xaml
    /// </summary>
    public partial class CharacterSelectScreen : Page
    {
        BattleScreen battleScreen;

        public CharacterSelectScreen()
        {
            InitializeComponent();
        }

        //"Choose Warrior" Button Functionality
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            battleScreen = new BattleScreen("Warrior");
            //choosePlayerCharacter("Warrior");
        }


        //"Choose Theif" Button Functionality
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            battleScreen = new BattleScreen("Thief");
            //choosePlayerCharacter("Thief");
        }


        //"Choose Mage" Button Functionality
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            battleScreen = new BattleScreen("Mage");
            //choosePlayerCharacter("Mage");
        }
    }
}
