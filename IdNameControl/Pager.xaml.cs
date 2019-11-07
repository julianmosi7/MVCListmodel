using ModelLib;
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

namespace Controls
{
    /// <summary>
    /// Interaction logic for Pager.xaml
    /// </summary>
    public partial class Pager : UserControl
    {
        int id;
                

        private ValueModel model;

        public ValueModel Model
        {
            get { return model; }
            set
            {
                model = value;                
                model.ValueChanged += Model_ValueChanged;
            }
        }

        private void Model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            id = e.ID;
        }

        public Pager()
        {
            InitializeComponent();
        }

        private void Button_Click_Up(object sender, RoutedEventArgs e)
        {
            model.ID = id + 1;
        }

        private void Button_Click_Down(object sender, RoutedEventArgs e)
        {
            model.ID = id - 1;
        }
    }
}
