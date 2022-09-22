using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SortingAlgoritms;

namespace SortingAlgorithms
{
    public partial class MainWindow
    {
        ViewManager viewManager = null;

        
        public MainWindow()
        {
            InitializeComponent();
            viewManager = new ViewManager();
            viewManager.Start();
        }

        private void SortButtonClick(object sender, RoutedEventArgs e)
        {
            viewManager.algorithm.BubbleSort(viewManager.UpdateBarChart, viewManager.ChangeBarColor);
            //viewManager.UpdateBarChart();
        }
        private void ShuffleButtonClick(object sender, RoutedEventArgs e)
        {
            viewManager.algorithm.ShuffleTable();
            viewManager.UpdateBarChart();
        }
    }
}
