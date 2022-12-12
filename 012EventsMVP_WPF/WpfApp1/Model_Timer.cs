using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApp1
{
    internal class Model_Timer
    {
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public TimeSpan dt = new TimeSpan(0, 0, 0, 0);
        
        public void TikTak()
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
    }
}
