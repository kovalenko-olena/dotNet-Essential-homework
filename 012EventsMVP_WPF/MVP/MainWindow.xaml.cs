using System;
using System.Reflection;
using System.Windows;
/*Измените существующий проект данного урока 003_MVP, расширив его добавлением методов доступа add и remove к событию.*/
// View

namespace MVP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        private event EventHandler myPrivateEvent = null;

        public event EventHandler myEvent
        {
            add
            {
                myPrivateEvent += value;
                //MessageBox.Show("add!!!!!");
            }
            remove
            {
                myPrivateEvent -= value;
                //MessageBox.Show("remove!!!!!");
            }
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myPrivateEvent.Invoke(sender, e);
        }
    }
}
