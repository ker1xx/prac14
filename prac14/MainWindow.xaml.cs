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

namespace prac14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Alltypes = new();
        public MainWindow()
        {
            InitializeComponent();
            Alltypes = y.Deserialize<List<string>>("allTypes.json");
            TypesDisplay.ItemsSource = Alltypes;
        }

        private void CreateType_Click(object sender, RoutedEventArgs e)
        {
            CreateNewTypeElementpage NewPage = new();
            NewPage.ShowDialog();
            if (NewPage.DialogResult == true)
            {
                Alltypes.Add(NewPage.NameOfNewType);
                y.Serialize<List<string>>(Alltypes, "allTypes.json");
                Alltypes = y.Deserialize<List<string>>("allTypes.json");
                TypesDisplay.ItemsSource = Alltypes;
            }
        }
    }
}
