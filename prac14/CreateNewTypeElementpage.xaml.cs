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
using System.Windows.Shapes;

namespace prac14
{
    /// <summary>
    /// Логика взаимодействия для CreateNewTypeElementpage.xaml
    /// </summary>
    public partial class CreateNewTypeElementpage : Window
    {
        public string NameOfNewType;
        public CreateNewTypeElementpage()
        {
            InitializeComponent();
        }

        private void FinalButton_Click(object sender, RoutedEventArgs e)
        {
            NameOfNewType = NewType.Text;
            DialogResult = true;
        }
    }
}
