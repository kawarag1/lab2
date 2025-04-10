using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для Quest2.xaml
    /// </summary>
    public partial class Quest2 : Window
    {
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();
        public Quest2()
        {
            InitializeComponent();
        }

        private void AddText_Click(object sender, RoutedEventArgs e)
        {
            Items.Clear();
            Items.Add(InputText.Text);
            Strings.ItemsSource = Items;

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Quest3 window = new Quest3();
            window.Show();
        }
    }
}
