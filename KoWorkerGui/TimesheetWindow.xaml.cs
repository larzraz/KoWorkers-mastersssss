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

namespace KoWorkerGui
{
    /// <summary>
    /// Interaction logic for TimesheetWindow.xaml
    /// </summary>
    public partial class TimesheetWindow : Window
    {
        public TimesheetWindow()
        {
            InitializeComponent();
        }

        private void AddSchedule_Button_Click(object sender, RoutedEventArgs e)
        {
            AddSchedule_Window asw = new AddSchedule_Window();
            App.Current.MainWindow = asw;
            asw.Show();
        }
    }
}
