using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApp1
{
    internal class Presenter_Timer
    {
        Model_Timer timer;
        MainWindow mainWindow;
        public Presenter_Timer(MainWindow window)
        {
            timer = new Model_Timer();
            mainWindow = window;
            mainWindow.Tick += new EventHandler(MainWindow_Tick);
            mainWindow.TickStop += new EventHandler(MainWindow_TickStop);
            mainWindow.TickZero += new EventHandler(MainWindow_TickZero);
            timer.dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        }
        private void MainWindow_Tick(object sender, EventArgs e)
        {
            timer.TikTak();
            dispatcherTimer_Tick(sender, e);
        }
        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            timer.dt = timer.dt.Add(TimeSpan.FromSeconds(1));
            mainWindow.Label.Content = timer.dt;
        }
        private void MainWindow_TickStop(object sender, EventArgs e)
        {
            timer.dispatcherTimer.Stop();
        }
        private void MainWindow_TickZero(object sender, EventArgs e)
        {
            MainWindow_TickStop(sender, e);
            timer.dt = new TimeSpan(0, 0, 0, 0);
            mainWindow.Label.Content = timer.dt;
        }
    }
}
