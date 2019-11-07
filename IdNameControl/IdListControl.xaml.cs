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

        public ValueModel Model
        {
            get { return model; }
            set
            {
                model = value;
                model.ValueChanged += model_ValueChanged;
                foreach (var item in model.dictionary)
                {
                    listBox.Items.Add($"{item.Key} - {item.Value}");
                }
                //in listbox speichern
            }
        }       

        private void model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblIdList.Content = e.ID;
            listBox.SelectedItem = e.ID;
        }

        public IdListControl()
        {
            InitializeComponent();
        }

        private void lblIdList_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            model.ID = Double.Parse(lblIdList.Content.ToString());
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //model.Val = listBox.SelectedItem.ToString();
        }
    }
}
