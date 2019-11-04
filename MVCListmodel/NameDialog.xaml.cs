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

namespace MVCListmodel
{
    /// <summary>
    /// Interaction logic for NameDialog.xaml
    /// </summary>
    public partial class NameDialog : Window
    {
        public List<string> Persons { get; set; }


        public NameDialog()
        {
            Persons = new List<string>();
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Persons.Add($"{txtBox1.Text} - 1");
            Persons.Add($"{txtBox2.Text} - 2");
            Persons.Add($"{txtBox3.Text} - 3");
            Persons.Add($"{txtBox4.Text} - 4");
            Persons.Add($"{txtBox5.Text} - 5");
            Persons.Add($"{txtBox6.Text} - 6");
            //MainWindow main = new MainWindow();
            //main.fill();
            Close();
        }
    }
}
