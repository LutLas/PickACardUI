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

namespace PickACardUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string NumberStorage = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedItem is ComboBoxItem comboBoxItem)
            {
                NumberStorage = comboBoxItem.Content.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListedCardsBox.Items.Clear();
            if (int.TryParse(NumberStorage, out int result))
            {
                foreach (string card in CardPicker.PickRandonCards(result))
                {
                    ListedCardsBox.Items.Add(card);
                }
            }
        }
    }
}
