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
    /// Interaction logic for IdListControl.xamlv
    /// </summary>
    public partial class IdListControl : UserControl
    {
        private ValueModel model;        

        Dictionary<string, int> dict = new Dictionary<string, int>();

        public ValueModel Model
        {
            get { return model; }
            set
            {
                model = value;
                model.ValueChanged += model_ValueChanged;
                dict = model.dictionary;
                foreach (var item in dict)
                {
                    listBox.Items.Add($"{item.Key} - {item.Value}");
                }                
            }
        }       

        private void model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblIdList.Content = e.ID;

            listBox.SelectedIndex = e.ID - 1;      
        }

        public IdListControl()
        {
            InitializeComponent();
        }

        private void lblIdList_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            model.ID = Int32.Parse(lblIdList.Content.ToString());
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            var index = listBox.SelectedIndex;            
            foreach (var item in dict)
            {
                if(item.Value == index+1)
                {
                    model.ID = item.Value;                    
                }
            }            
        }
    }
}
