﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            decimal a = Convert.ToDecimal(DigitA.Text);
            decimal b = Convert.ToDecimal(DigitB.Text);
            Result.Text = Convert.ToString($"{a + b}");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            decimal a = Convert.ToDecimal(DigitA.Text);
            decimal b = Convert.ToDecimal(DigitB.Text);
            Result.Text = Convert.ToString($"{a - b}");
        }

        private void Miltiplication_Click(object sender, RoutedEventArgs e)
        {
            decimal a = Convert.ToDecimal(DigitA.Text);
            decimal b = Convert.ToDecimal(DigitB.Text);
            Result.Text = Convert.ToString($"{a * b}");
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            decimal a = Convert.ToDecimal(DigitA.Text);
            decimal b = Convert.ToDecimal(DigitB.Text);
            if (b == 0)
            {
                MessageBox.Show("Деление на 0!");
            }
            else
            {
                Result.Text = Convert.ToString($"{a / b}");
            }
                
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Quest2 window = new Quest2();
            window.Show();
        }
    }
}