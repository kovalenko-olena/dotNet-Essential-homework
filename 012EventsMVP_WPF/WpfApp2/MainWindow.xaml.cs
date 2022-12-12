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
/*Задание 4 

Используя Visual Studio, создайте проект по шаблону WPF Application. 
Создайте калькулятор на четыре арифметических действия (сложение, вычитание, умножение и деление). Для реализации калькулятора используйте паттерн MVP. */
namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new ViewCalc(this);
            Txt = "";
        }
        public event EventHandler Clc = null;
        public string Txt { get; set; }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Txt += "1";
            this.lbl.Content=Txt;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Txt += "2";
            this.lbl.Content = Txt;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Txt += "3";
            this.lbl.Content = Txt;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Txt += "4";
            this.lbl.Content = Txt;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Txt += "5";
            this.lbl.Content = Txt;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Txt += "6";
            this.lbl.Content = Txt;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Txt += "7";
            this.lbl.Content = Txt;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            Txt += "8";
            this.lbl.Content = Txt;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            Txt += "9";
            this.lbl.Content = Txt;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            Txt += "0";
            this.lbl.Content = Txt;
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            Txt += ",";
            this.lbl.Content = Txt;
        }

        private void btnDev_Click(object sender, RoutedEventArgs e)
        {
            Txt += "/";
            this.lbl.Content = Txt;
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            Txt += "*";
            this.lbl.Content = Txt;
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            Txt += "-";
            this.lbl.Content = Txt;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Txt += "+";
            this.lbl.Content = Txt;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            Clc.Invoke(sender, e);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Txt = "";
            this.lbl.Content = 0;
        }
    }
}
