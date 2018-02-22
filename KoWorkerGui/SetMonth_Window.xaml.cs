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
    /// Interaction logic for SetMonth_Window.xaml
    /// </summary>
    public partial class SetMonth_Window : Window
    {
        public SetMonth_Window()
        {
            InitializeComponent();
            FillComboBoxes();
        }
        DateTime dt = new DateTime();
       public void SetDateTime (DateTime dateTime)
        {
            dt = dateTime;
        }
        private void FillComboBoxes()
        {
            string[] years = new string[] { "2018", "2017", "2016", "2015", "2014" };
            string[] months = new string[] { "Januar", "Februar", "Marts", "April", "Maj", "Juni", "Juli", "August", "September", "Oktober", "November", "December" };
            foreach (string month in months)
            { Month_Button.Items.Add(month); }
            foreach (string year in years)
            { Year_Button.Items.Add(year); }
        }
        int month = 0;
        int year = DateTime.Now.Year;

        public DateTime GetDateTime()
        {
            return dt;
        }

        private void SetMonthOK_Button_Click(object sender, RoutedEventArgs e)
        {
            month = Month_Button.SelectedIndex + 1;
            year = int.Parse(Year_Button.SelectedItem.ToString());
            DateTime monthAndYeah = new DateTime(year, month,27);
            SetDateTime(monthAndYeah);
        }
    }
}
