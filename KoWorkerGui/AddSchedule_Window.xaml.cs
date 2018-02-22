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
using KoWorkers;

namespace KoWorkerGui
{
    /// <summary>
    /// Interaction logic for AddSchedule_Window.xaml
    /// </summary>
    public partial class AddSchedule_Window : Window
    {
        PickEmployees_Window pw = new PickEmployees_Window();
        SetMonth_Window sw = new SetMonth_Window();
        AddShift_Window aw = new AddShift_Window();
        Controller control;
        public AddSchedule_Window()
        {
            control = Controller.GetInstance();
            InitializeComponent();
            
        }
        DateTime dt = new DateTime();
        private void Set_Employees_Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            
            App.Current.MainWindow = pw;
            pw.Show();
        }

        private void SetMonth_Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            
            App.Current.MainWindow = sw;
            sw.Show();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

            List<Employee> list = pw.GetList();
            dt = sw.GetDateTime();
            Month_Label.Content = dt.Month;
            Year_Label.Content = dt.Year;
            Schedule_DataGridView.ItemsSource = list;
        }
        public DateTime GetEndTime(int endTime)
        {
            DateTime dateTime = new DateTime(dt.Year, dt.Month, 27, endTime, 0, 0);
            return dateTime;
        }

        public DateTime GetStartTime(int startTime)
        {
            DateTime dateTime = new DateTime(dt.Year, dt.Month, 27, startTime, 0, 0);
            return dateTime;
        }

        private void AddShifts_Button_Click(object sender, RoutedEventArgs e)
        {
          
            App.Current.MainWindow = aw;
            aw.Show();

        }

        private void AddShiftreal_Button_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = Schedule_DataGridView.SelectedItem as Employee;
            int starttime = aw.getStartTime();
            int endTime = aw.getEndTime();
            DateTime end = GetEndTime(endTime);
            DateTime start = GetStartTime(starttime);
            int pin = emp.PinCode;
            string message = "";

            message = control.CheckShiftByPin(pin, start, end);
            MessageBox.Show(message, "KoWorkers");
        }
    }
}
