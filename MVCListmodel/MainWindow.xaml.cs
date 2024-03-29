﻿using ModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVCListmodel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private readonly ValueModel model = new ValueModel();             

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {            
            model.ValueChanged += Model_ValueChanged;
            //namedialog.Show();
            //fill();

            foreach (UIElement control in panMain.Children)
            {
                if (control is Controls.IdNameControl idnamecontrol) idnamecontrol.Model = model;
                if (control is Controls.IdListControl idlistcontrol)
                {
                    idlistcontrol.Model = model;
                }           
                if (control is Controls.Pager pager) pager.Model = model;
            }            
        }        

        private void Model_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //nur eigene Controls setzen
        }        

    }
}
