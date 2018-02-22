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
    /// Interaction logic for AddShift_Window.xaml
    /// </summary>
    public partial class AddShift_Window : Window
    {
        public AddShift_Window()
        {
            InitializeComponent();
        }
        int start = 0;
        int end = 0;
        public void SetStartAndEndTime (int Start, int End)
        {
            start = Start;
            end = End;
        }

        public int getStartTime()
        {
            return start;
        }
        public int getEndTime()
        {
            return end;
        }
        private void sixToTen_Buttn_Click(object sender, RoutedEventArgs e)
        {
            SetStartAndEndTime(6, 10);
        }

        private void seventeenTo00_button_Click(object sender, RoutedEventArgs e)
        {
            SetStartAndEndTime(17, 24);
        }

        private void elevenTo14_Buttn_Copy1_Click(object sender, RoutedEventArgs e)
        {
            SetStartAndEndTime(11, 14);
        }

        private void Okay_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
