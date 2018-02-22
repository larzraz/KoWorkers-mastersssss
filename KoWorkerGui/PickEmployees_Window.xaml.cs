using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
    /// Interaction logic for PickEmployees_Window.xaml
    /// </summary>
    public partial class PickEmployees_Window : Window
    {
        Controller control;
        //public bool IsCheckBoxChecked
        //{
        //    get { return (bool)GetValue(IsCheckBoxCheckedProperty); }
        //    set { SetValue(IsCheckBoxCheckedProperty, value); }
        //}

        // Using a DependencyProperty as the backing store for 
        //IsCheckBoxChecked.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty IsCheckBoxCheckedProperty =
        //    DependencyProperty.Register("IsCheckBoxChecked", typeof(bool),
        //      typeof(PickEmployees_Window), new UIPropertyMetadata(false));
        public PickEmployees_Window()
        {
            control = Controller.GetInstance();
            InitializeComponent();
            datagrid.ItemsSource= control.GetAllEmployees();
            List<Employee> emplist = control.GetAllEmployees();
        }
        List<Employee> listToSend = new List<Employee>();
        public void GetPickedEmployeesToList()
        {

        }
        List<Employee> employeeList = new List<Employee>();
        public List<Employee> EmpList
        {

            get { setList(); return employeeList; }
        }
      
        public void setList()
        {

           employeeList = control.GetAllEmployees(); 
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        public void SendList(List<Employee> list)
        {
            listToSend = list;
           
        }
        public List<Employee> GetList()
        {
            return listToSend;
        }
          
        private void Pick_Button_Click(object sender, RoutedEventArgs e)
        {
        
            setList();
            var SelectedList = new List<Employee>();
            for (int i = 2; i < datagrid.Items.Count; i++)
            {
                var item = datagrid.Items[i];
                string test = item.ToString();
                SelectedList.Add(employeeList[i]);
                var Checkbox_Employee = datagrid.Columns[1].GetCellContent(item) as CheckBox;
                //if ((bool)Checkbox_Employee.IsChecked)
                //{
                //    SelectedList.Add(employeeList[i]);
                //}
                SendList(SelectedList);
                
            }
        }
    }
}
