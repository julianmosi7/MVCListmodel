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
            
        }

        public Pager()
        {
            InitializeComponent();
        }
    }
}
