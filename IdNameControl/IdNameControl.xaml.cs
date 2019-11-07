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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class IdNameControl : UserControl
    {     
               
        private ValueModel model;

        Dictionary<string, int> dict = new Dictionary<string, int>();


        public ValueModel Model
        {
            get { return model; }
            set
            {
                model = value;                
                model.ValueChanged += Model_ValueChanged;
                dict = model.dictionary;
            }
        }

        private void Model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            foreach (var item in dict)
            {
                if(item.Value == e.ID)
                {
                    lblId.Content = item.Value;
                    lblName.Content = item.Key;
                }
            }
        }

        public IdNameControl()
        {
            InitializeComponent();
        }
    }
}
