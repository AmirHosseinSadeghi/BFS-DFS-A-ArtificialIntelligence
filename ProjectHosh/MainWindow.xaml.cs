﻿using System;
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
        int[] StartPosition;
        int OpenNodes;
        bool Success;
        bool HandyPattern;
        bool SelectRed;
        bool SelectGreen;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            Labels = new Label[20, 30];
            StartPosition = new int[2];
            OpenNodes = 0;
            Success = false;
            HandyPattern = false;
            SelectRed = true;
            SelectGreen = true;
            MakeMap();
            Searchbtn.IsEnabled = false;
        }

        private void MakeMap()
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
                    lb.MouseLeftButtonUp += Lb_MouseLeftButtonUp;
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
        }

        private void Lb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (HandyPattern)
            {
                var temp = (Label)sender;
                var backgroundColor = temp.Background;
                var color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    if (SelectRed)
                    {
                        temp.Background = new SolidColorBrush(Colors.Red);
                        StartPosition[0] = Grid.GetRow(temp);
                        StartPosition[1] = Grid.GetColumn(temp);
                        SelectRed = false;
                    }
                    else if (SelectGreen)
                    {
                        temp.Background = new SolidColorBrush(Colors.Green);
                        SelectGreen = false;
                    }
                    else
                    {
                        temp.Background = new SolidColorBrush(Colors.Black);
                        Searchbtn.IsEnabled = true;
                    }
                }
            }
        }

        private void GeneratePatternbtn_Click(object sender, RoutedEventArgs e)
        {
            HandyPattern = false;
            SelectRed = true;
            SelectGreen = true;
            Clear();

            Random random = new Random();
            int i = random.Next(1, 19);
            int j = random.Next(1, 29);
            Labels[i, j].Background = new SolidColorBrush(Colors.Red);
            StartPosition[0] = i;
            StartPosition[1] = j;

            while (true)
            {
                i = random.Next(1, 19);
                j = random.Next(1, 29);
                var backgroundColor = Labels[i, j].Background;
                var color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    Labels[i, j].Background = new SolidColorBrush(Colors.Green);
                    break;
                }

            }

            int t = random.Next(0, 350);// 600-30-30-18-18-2 = 502
            while (t >= 0)
            {
                i = random.Next(1, 19);
                j = random.Next(1, 29);
                var backgroundColor = Labels[i, j].Background;
                var color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    Labels[i, j].Background = new SolidColorBrush(Colors.Black);
                    t--;
                }
            }

            Searchbtn.IsEnabled = true;
        }

        private void Clear()
        {
            Searchbtn.IsEnabled = false;
            HandyPattern = false;
            SelectRed = true;
            SelectGreen = true;

            for (int i = 1; i < 19; i++)
            {
                for (int j = 1; j < 29; j++)
                {
                    var backgroundColor = Labels[i, j].Background;
                    var color = ((SolidColorBrush)backgroundColor).Color.ToString();
                    if (color != new SolidColorBrush(Colors.White).ToString())
                    {
                        Labels[i, j].Background = new SolidColorBrush(Colors.White);
                        Labels[i, j].Content = null;
                    }
                }
            }
        }

        private void BFS_Algoritm()
        {
            Success = false;
            OpenNodes = 0;
            var timer = System.Diagnostics.Stopwatch.StartNew();
            Queue<Label> waitingQueue = new Queue<Label>();
            Queue<Label> visitedQueue = new Queue<Label>();
            int i = StartPosition[0];
            int j = StartPosition[1];
            visitedQueue.Enqueue(Labels[i, j]);
            Brush backgroundColor;
            string color;
            while (true)
            {
                backgroundColor = Labels[i - 1, j].Background;
                color = ((SolidColorBrush)backgroundColor).Color.ToString();
                // Top
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    waitingQueue.Enqueue(Labels[i - 1, j]);
                    Labels[i - 1, j].Background = new SolidColorBrush(Colors.LightPink);
                    Labels[i - 1, j].Content = $"{i - 1},{j},{i},{j}";
                }
                else if (color == new SolidColorBrush(Colors.Green).ToString())
                {
                    Success = true;
                    break;
                }

                // Right
                backgroundColor = Labels[i, j + 1].Background;
                color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    waitingQueue.Enqueue(Labels[i, j + 1]);
                    Labels[i, j + 1].Background = new SolidColorBrush(Colors.LightPink);
                    Labels[i, j + 1].Content = $"{i},{j + 1},{i},{j}";
                }
                else if (color == new SolidColorBrush(Colors.Green).ToString())
                {
                    Success = true;
                    break;
                }

                // Bottom
                backgroundColor = Labels[i + 1, j].Background;
                color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    waitingQueue.Enqueue(Labels[i + 1, j]);
                    Labels[i + 1, j].Background = new SolidColorBrush(Colors.LightPink);
                    Labels[i + 1, j].Content = $"{i + 1},{j},{i},{j}";
                }
                else if (color == new SolidColorBrush(Colors.Green).ToString())
                {
                    Success = true;
                    break;
                }

                // Left
                backgroundColor = Labels[i, j - 1].Background;
                color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    waitingQueue.Enqueue(Labels[i, j - 1]);
                    Labels[i, j - 1].Background = new SolidColorBrush(Colors.LightPink);
                    Labels[i, j - 1].Content = $"{i},{j - 1},{i},{j}";
                }
                else if (color == new SolidColorBrush(Colors.Green).ToString())
                {
                    Success = true;
                    break;
                }

                if (waitingQueue.Count == 0)
                    break;
                var temp = waitingQueue.Dequeue();
                while (true)
                {
                    if (visitedQueue.Contains(temp))
                        temp = waitingQueue.Dequeue();
                    else
                        break;
                }
                visitedQueue.Enqueue(temp);
                var currentPosition = temp.Content.ToString();
                var x = currentPosition.Split(',');
                i = Convert.ToInt32(x[0]);
                j = Convert.ToInt32(x[1]);
            }

            if (Success)
            {
                if (i != StartPosition[0] && j != StartPosition[1])
                {
                    int counter = 1;
                    var currentPosition = Labels[i, j].Content.ToString();
                    string[] x;
                    while (true)
                    {
                        if (i == StartPosition[0] && j == StartPosition[1])
                            break;
                        Labels[i, j].Background = new SolidColorBrush(Colors.LightBlue);
                        currentPosition = Labels[i, j].Content.ToString();
                        Labels[i, j].Content = counter;
                        counter++;
                        OpenNodes++;
                        x = currentPosition.Split(',');
                        i = Convert.ToInt32(x[2]);
                        j = Convert.ToInt32(x[3]);
                    }
                }
            }
            foreach (Label lb in Labels)
            {
                backgroundColor = lb.Background;
                color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.LightPink).ToString())
                {
                    OpenNodes++;
                    lb.Content = null;
                }
            }
            timer.Stop();
            TimeLb.Content = timer.ElapsedMilliseconds + "  ms";
            OpenNodesLb.Content = OpenNodes;
            if (!Success)
                MessageBox.Show("Couldn’t find pass", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DFS_Algoritm()
        {
            Success = false;
            OpenNodes = 0;
            var timer = System.Diagnostics.Stopwatch.StartNew();
            Stack<Label> road = new Stack<Label>();
            int i = StartPosition[0];
            int j = StartPosition[1];
            Brush backgroundColor;
            string color;
            while (true)
            {
                backgroundColor = Labels[i - 1, j].Background;
                color = ((SolidColorBrush)backgroundColor).Color.ToString();
                // Top
                if (color == new SolidColorBrush(Colors.White).ToString())
                {
                    road.Push(Labels[i, j]);
                    i--;
                    Labels[i, j].Background = new SolidColorBrush(Colors.LightPink);
                }
                else if (color == new SolidColorBrush(Colors.Green).ToString())
                {
                    road.Push(Labels[i, j]);
                    Success = true;
                    break;
                }
                else
                {
                    // Right
                    backgroundColor = Labels[i, j + 1].Background;
                    color = ((SolidColorBrush)backgroundColor).Color.ToString();
                    if (color == new SolidColorBrush(Colors.White).ToString())
                    {
                        road.Push(Labels[i, j]);
                        j++;
                        Labels[i, j].Background = new SolidColorBrush(Colors.LightPink);
                    }
                    else if (color == new SolidColorBrush(Colors.Green).ToString())
                    {
                        road.Push(Labels[i, j]);
                        Success = true;
                        break;
                    }
                    else
                    {
                        // Bottom
                        backgroundColor = Labels[i + 1, j].Background;
                        color = ((SolidColorBrush)backgroundColor).Color.ToString();
                        if (color == new SolidColorBrush(Colors.White).ToString())
                        {
                            road.Push(Labels[i, j]);
                            i++;
                            Labels[i, j].Background = new SolidColorBrush(Colors.LightPink);
                        }
                        else if (color == new SolidColorBrush(Colors.Green).ToString())
                        {
                            road.Push(Labels[i, j]);
                            Success = true;
                            break;
                        }
                        else
                        {
                            // Left
                            backgroundColor = Labels[i, j - 1].Background;
                            color = ((SolidColorBrush)backgroundColor).Color.ToString();
                            if (color == new SolidColorBrush(Colors.White).ToString())
                            {
                                road.Push(Labels[i, j]);
                                j--;
                                Labels[i, j].Background = new SolidColorBrush(Colors.LightPink);
                            }
                            else if (color == new SolidColorBrush(Colors.Green).ToString())
                            {
                                road.Push(Labels[i, j]);
                                Success = true;
                                break;
                            }
                            else
                            {
                                if (road.Count == 0) // in bara inke agar be startposition back zad do halat be vojod miad.ya be ye 
                                    break;  //jahat dige mire ya am ke 4 tarafsh ro test karde va javabi peida nakarde;
                                var item = road.Pop();
                                i = Grid.GetRow(item);
                                j = Grid.GetColumn(item);
                            }
                        }
                    }
                }
            }
            if (Success)
            {
                int counter = road.Count - 1;
                Label item;
                while (true)
                {
                    item = road.Pop();
                    i = Grid.GetRow(item);
                    j = Grid.GetColumn(item);
                    if (i == StartPosition[0] && j == StartPosition[1])
                        break;
                    Labels[i, j].Background = new SolidColorBrush(Colors.LightBlue);
                    Labels[i, j].Content = counter;
                    counter--;
                    OpenNodes++;
                }
            }
            foreach (Label lb in Labels)
            {
                backgroundColor = lb.Background;
                color = ((SolidColorBrush)backgroundColor).Color.ToString();
                if (color == new SolidColorBrush(Colors.LightPink).ToString())
                {
                    OpenNodes++;
                    lb.Content = null;
                }
            }
            timer.Stop();
            TimeLb.Content = timer.ElapsedMilliseconds + "  ms";
            OpenNodesLb.Content = OpenNodes;
            if (!Success)
                MessageBox.Show("Couldn’t find pass", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Clearbtn_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            HandyPattern = false;
            SelectRed = true;
            SelectGreen = true;

            if (combobox.SelectedIndex == 0)
                BFS_Algoritm();
            if (combobox.SelectedIndex == 1)
                DFS_Algoritm();
        }

        private void HandyPatternbtn_Click(object sender, RoutedEventArgs e)
        {
            HandyPattern = true;
        }
    }
}
