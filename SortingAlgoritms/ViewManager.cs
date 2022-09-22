using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SortingAlgorithms;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace SortingAlgorithms 
{
    public class ViewManager
    {
        
        Rectangle rect;
        
       
        public List<Rectangle> bars = new List<Rectangle>();
        MainWindow mainWindow = Application.Current.Windows[0] as MainWindow;
        public Algorithm algorithm = new Algorithm(1, 300, 15);

        public void Start()
        {
            CreateBarChart();
        }

        private void CreateBarChart()
        {
            algorithm.GenerateRandomTable();
            for (int i = 0; i < algorithm.GetTableLenght(); i++)
            {
                rect = new Rectangle();
                rect.Height = 20;
                rect.Width = algorithm.GetTableItem(i);
                rect.Fill = new SolidColorBrush(Color.FromRgb(0, 111, 111));
                bars.Add(rect);
            }
            mainWindow.listBox.ItemsSource = bars;
        }
        public void UpdateBarChart()
        {
            for (int i = 0; i < algorithm.GetTableLenght(); i++)
            {
                bars[i].Width = algorithm.GetTableItem(i);
                bars[i].Fill = new SolidColorBrush(Color.FromRgb(0, 111, 111));
            }
            
        }
        public void ChangeBarColor(int i)
        {
            bars[i + 1].Fill = new SolidColorBrush(Color.FromRgb(128, 0, 0));
        }
        public void ChangeTableLenght()
        {
            int newTableLenght = Convert.ToInt32(mainWindow.tableLenghtBox.Text);
            algorithm.SetTableLenght(newTableLenght);
        }
       
        
    }
    
}
