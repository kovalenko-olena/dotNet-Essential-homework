using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class ViewCalc
    {
        Calc calc;
        MainWindow mainWindow;
        public ViewCalc(MainWindow window)
        {
            calc = new Calc();
            mainWindow = window;
            mainWindow.Clc += new EventHandler(MainWindow_Clc);
        }
        private void MainWindow_Clc(object sender, EventArgs e)
        {
            string result = calc.Clc(mainWindow.lbl.Content.ToString());
            mainWindow.lbl.Content = result;
            if (result != "0") mainWindow.Txt = result;
            else mainWindow.Txt = "";
        }
    }
}
