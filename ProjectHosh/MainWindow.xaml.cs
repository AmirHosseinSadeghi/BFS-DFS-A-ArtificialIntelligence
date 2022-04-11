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

namespace ProjectHosh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region LocalVariable
        Label[,] Labels;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            Labels = new Label[20, 30];
            MakeMap();
        }

        public void MakeMap()
        {
            #region ColumnDefinitions
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            Map.ColumnDefinitions.Add(new ColumnDefinition());
            #endregion

            #region RowDefinitions
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            Map.RowDefinitions.Add(new RowDefinition());
            #endregion

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Label lb = new Label();
                    lb.BorderThickness = new Thickness(1);
                    if (i == 0 || i == 19 || j == 0 || j == 29)
                        lb.Background = new SolidColorBrush(Colors.Black);
                    else
                        lb.Background = new SolidColorBrush(Colors.White);
                    Grid.SetColumn(lb, j);
                    Grid.SetRow(lb, i);
                    Map.Children.Add(lb);
                    Labels[i, j] = lb;
                }
            }
            ///////////////////////////////////////اعمال شرط اینکه فقط اگز خونه ایی سفید بود رنگشو تغییر بده.
            //Random random = new Random();
            //Labels[random.Next(1, 19), random.Next(1, 29)].Background = new SolidColorBrush(Colors.Green);
            //Labels[random.Next(1, 19), random.Next(1, 29)].Background = new SolidColorBrush(Colors.Red);
            //int t = random.Next(0, 503);// 600-30-30-18-18-2 = 502
            //while (t >= 0)
            //{
            //    Labels[random.Next(1, 19), random.Next(1, 29)].Background = new SolidColorBrush(Colors.Black);
            //    t--;
            //}
        }
    }
}
