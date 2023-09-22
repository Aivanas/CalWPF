using System;
using System.Windows;
using System.Windows.Controls;

namespace CalWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //makeCal(DateTime.Now.Month);
            makeCal(2);
        }

        private void makeCal(int month)
        {
            int[] monthDays = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 30};
            int row = 0;
            int column = 0;
            for (int i = 0; i < monthDays[month - 1]; i++)
            {
                Button button = new Button();
                button.Content = (i+1).ToString();
                button.Margin = new Thickness(1);
                button.Name = "Button" + i;
                
                DatesGrid.Children.Add(button);
                if (column <= 7)
                {
                    Grid.SetColumn(button, column);
                    Grid.SetRow(button, row);
                    column++;
                }
                else
                {
                    column = 0;
                    row++;
                    Grid.SetColumn(button, column);
                    Grid.SetRow(button, row);
                }
                
                
                
                
            }
        }
        
        
    }
}