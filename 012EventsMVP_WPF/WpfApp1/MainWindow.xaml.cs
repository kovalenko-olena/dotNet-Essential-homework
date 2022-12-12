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
using System.Windows.Threading;
/*Задание 3

Используя Visual Studio, создайте проект по шаблону WPF Application. Создайте программу секундомер. Требуется выводить показания секундомера в окне. 
    Окно имеет кнопки запуска, остановки и сброса секундомера. Для реализации секундомера используйте паттерн MVP. */
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter_Timer(this);
        }

        public event EventHandler Tick;
        public event EventHandler TickStop;
        public event EventHandler TickZero;
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            Tick.Invoke(sender, e);
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            TickStop.Invoke(sender, e);
        }

        private void BtnZero_Click(object sender, RoutedEventArgs e)
        {
            TickZero.Invoke(sender, e);
        }
    }
}
