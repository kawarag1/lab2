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
using lab2.Classes;

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для Quest3.xaml
    /// </summary>
    public partial class Quest3 : Window
    {
        public static List<Planet> Planets = new List<Planet>()
        {
            new Planet()
            {
                Name = "Меркурий",
                Description = "Самая маленькая и ближайшая к солнцу планета."
            },

            new Planet()
            {
                Name = "Венера",
                Description = "Вторая планета от Солнца, самая горячая в Солнечной системе."
            },

            new Planet()
            {
                Name = "Земля",
                Description = "Наш дом, третья планета от Солнца, единственная известная с жизнью."
            },

            new Planet()
            {
                Name = "Марс",
                Description = "Красная планета из-за оксида железа в почве. Имеет тонкую атмосферу (в основном CO₂), полярные ледяные шапки и самый высокий вулкан в Солнечной системе — Олимп (21 км). Возможно, в прошлом на Марсе была вода."
            },
            new Planet()
            {
                Name = "Юпитер",
                Description = "Крупнейшая планета Солнечной системы — газовый гигант, состоящий в основном из водорода и гелия. Известен Большим Красным Пятном — гигантским штормом, бушующим сотни лет. Имеет 95 известных спутников, включая Ганимед (крупнее Меркурия)."
            },

            new Planet()
            {
                Name = "Сатурн",
                Description = "Второй по величине газовый гигант, знаменитый своими кольцами из льда и камня. Как и Юпитер, состоит в основном из водорода. Имеет 146 спутников, включая Титан с плотной атмосферой и метановыми озёрами."
            },

            new Planet()
            {
                Name = "Уран",
                Description = "Ледяной гигант с необычным наклоном оси (98°), из-за чего вращается \"лёжа на боку\". Состоит из воды, аммиака и метана, придающего ему голубой оттенок. Имеет 27 спутников и слабые кольца."
            },
            new Planet()
            {
                Name = "Нептун",
                Description = "Самый ветреный мир в Солнечной системе — скорости ветра достигают 2100 км/ч. Как и Уран, это ледяной гигант с синим цветом из-за метана. Открыт благодаря математическим расчётам (первая предсказанная планета)."
            }
        };
        public Quest3()
        {
            InitializeComponent();
            PlanetsView.ItemsSource = Planets;
        }

        private void PlanetsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Planet = PlanetsView.SelectedItem as Planet;
            Decs.Text = Planet.Description;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Quest4 window = new Quest4();
            window.Show();
        }
    }
}
