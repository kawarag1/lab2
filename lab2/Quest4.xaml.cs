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
using System.Windows.Shapes;

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для Quest4.xaml
    /// </summary>
    public partial class Quest4 : Window
    {
        public Quest4()
        {
            InitializeComponent();
            InitializeYearComboBox();
            InitializeMonthComboBox();
        }

        private void InitializeYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            List<int> years = Enumerable.Range(currentYear - 100, 101).Reverse().ToList();
            YearComboBox.ItemsSource = years;
        }

        private void InitializeMonthComboBox()
        {
            List<string> months = new List<string>
            {
                "Январь",
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Август",
                "Сентябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь"
            };
            MonthComboBox.ItemsSource = months;
        }

        private void InitializeDayComboBox(int year, int month)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);
            List<int> days = Enumerable.Range(1, daysInMonth).ToList();
            DayComboBox.ItemsSource = days;
            DayComboBox.IsEnabled = true;
        }

        private void YearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YearComboBox.SelectedItem != null && MonthComboBox.SelectedItem != null)
            {
                int year = (int)YearComboBox.SelectedItem;
                int month = (int)MonthComboBox.SelectedItem;
                InitializeDayComboBox(year, month);
            }
            else
            {
                DayComboBox.IsEnabled = false;
                DayComboBox.SelectedItem = null;
            }
        }

        private void MonthComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YearComboBox.SelectedItem != null && MonthComboBox.SelectedItem != null)
            {
                int year = (int)YearComboBox.SelectedItem;
                int month = (int)MonthComboBox.SelectedIndex + 1;
                InitializeDayComboBox(year, month);
            }
            else
            {
                DayComboBox.IsEnabled = false;
                DayComboBox.SelectedItem = null;
            }
        }

        private void DayComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YearComboBox.SelectedItem != null &&
               MonthComboBox.SelectedItem != null &&
               DayComboBox.SelectedItem != null)
            {
                CalculateDateDifference();
            }
        }

        private void CalculateDateDifference()
        {
            int year = (int)YearComboBox.SelectedItem;
            int month = (int)MonthComboBox.SelectedIndex + 1;
            int day = (int)DayComboBox.SelectedItem;

            DateTime selectedDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            if (selectedDate > currentDate)
            {
                MessageBox.Show("Выбранная дата в будущем!");
                return;
            }

            TimeSpan difference = currentDate - selectedDate;

            
            int years = currentDate.Year - selectedDate.Year;
            if (currentDate.Month < selectedDate.Month ||
                (currentDate.Month == selectedDate.Month && currentDate.Day < selectedDate.Day))
            {
                years--;
            }

            
            int months = 0;
            DateTime tempDate = selectedDate.AddYears(years);
            if (currentDate >= tempDate)
            {
                months = currentDate.Month - tempDate.Month;
                if (currentDate.Day < tempDate.Day)
                {
                    months--;
                }
                if (months < 0)
                {
                    months += 12;
                }
            }

            
            int days = (currentDate - tempDate.AddMonths(months)).Days;

            MessageBox.Show($"Прошло с {selectedDate.ToShortDateString()}:\n" +
                                  $"{years} лет, {months} месяцев и {days} дней");
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Quest5 window = new Quest5();
            window.Show();
        }
    }
}
