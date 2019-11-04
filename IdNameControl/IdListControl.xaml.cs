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
            }
        }       

        public double Val
        {
            get => Double.Parse(lblIdList.Content.ToString());
            set
            {
                
                model.Val = value;
            }
        }


        private string person;

        public string Person
        {
            get { return person; }
            set
            {
                person = $"Hansi - {1}";                
                listBox.Items.Add(person);
                person = $"Pauli - {2}";
                listBox.Items.Add(person);
                person = $"Susi - {3}";
                listBox.Items.Add(person);
                person = $"Franzi - {4}";
                listBox.Items.Add(person);
                person = $"Liesi - {5}";
                listBox.Items.Add(person);
                person = $"Heinzi - {6}";
                listBox.Items.Add(person);
            }
        }


        private void model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblIdList.Content = e.Val;
            listBox.SelectedItem = e.Val;
        }

        public IdListControl()
        {
            InitializeComponent();
        }

        private void lblIdList_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            model.Val = Double.Parse(lblIdList.Content.ToString());
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //model.Val = listBox.SelectedItem.ToString();
        }
    }
}
