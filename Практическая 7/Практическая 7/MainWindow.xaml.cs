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

namespace Практическая_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Fraction _firstPair;
        private Fraction _secondPair;

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GetInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Дударев И. В. ИСП-34. \nВариант 4.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SetParametrs_Click(object sender, RoutedEventArgs e)
        {
            _firstPair = new Fraction(int.Parse(pair1first.Text), int.Parse(pair1second.Text));
            _secondPair = new Fraction(int.Parse(pair2first.Text), int.Parse(pair2second.Text));
        }

        private void GetComprarisons_Click(object sender, RoutedEventArgs e)
        {
            if (_firstPair.AreEqual(_secondPair))
            {
                MessageBox.Show("Пары равны!", "Проверка пар на рввенство", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пары не равны!", "Проверка пар", MessageBoxButton.OK, MessageBoxImage.Information);
                if (_firstPair > _secondPair)
                {
                    MessageBox.Show("Первая пара больше второй!", "Проверка пар", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else MessageBox.Show("Первая пара меньше второй!", "Проверка пар", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }           
    }
}
