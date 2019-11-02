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

namespace IdNameControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class IdNameControl : UserControl
    {
        private string id;

        public string Id
        {
            get { return id; }
            set 
            { 
                id = value;
                lblId.Content = id; 
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                lblId.Content = name; 
            }
        }



        public IdNameControl()
        {
            InitializeComponent();
        }
    }
}
