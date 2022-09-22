using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SortingAlgoritms;

namespace SortingAlgorithms
{
    public class Algorithm
    {
        private int tableLenght;
        private int maxValue;
        private int minValue;

        private List<int> table = new List<int> { };
        public Algorithm(int min, int max, int lenght)
        {
            minValue = min;
            maxValue = max;
            tableLenght = lenght;
        }
        public int GetTableItem(int i)
        {
            return table[i];
        }
        public void GenerateRandomTable()
        {
            int temp;
            Random r = new Random();
            for (int i = 0; i < tableLenght; i++)
            {
                temp = r.Next(minValue, maxValue);
                table.Add(temp);
            }
        }
        public void ShuffleTable()
        {
            int temp;
            Random r = new Random();
            for (int i = 0; i < tableLenght; i++)
            {
                temp = r.Next(minValue, maxValue);
                table[i] = temp;
            }
        }
        public void SetMinValue(int x)
        {
            minValue = x;
        }
        public void SetMaxValue(int x)
        {
            maxValue = x;
        }
        public void SetTableLenght(int x)
        {
            if (x <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            try
            {                
                tableLenght = x;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Table lenght is less than or equal to 0.");
            }
                
        }
        public int GetTableLenght()
        {
            return tableLenght;
        }
        public async void BubbleSort(Action FunctionToPass, Action<int> ChangeBarColor)
        {
            bool sorted = false;
            int temp;
            int j = 0;
            while (sorted == false)
            {
                sorted = true;
                for (j = 0; j < table.Count() - 1; j++)
                {   
                    if (table[j] > table[j + 1])
                    {
                        sorted = false;
                        temp = table[j];
                        table[j] = table[j + 1];
                        table[j + 1] = temp;
                        FunctionToPass(); 
                    }
                    ChangeBarColor(j);
                    await Task.Delay(TimeSpan.FromSeconds(0.5));
                }
            }

        }

    }
}
