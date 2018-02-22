﻿using System;
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
    /// Interaction logic for AddEmployee_Window.xaml
    /// </summary>
    public partial class AddEmployee_Window : Window
    {
        Controller control;     
        public AddEmployee_Window()
        {
            InitializeComponent();
            control = Controller.GetInstance();
        }

        private void TelephoneNo_TextBox_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
          
            this.Close();
            
        }

        private void AddEmployee_Button_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstName_TextBox.Text;
            string lastName = LastName_TextBox.Text;
            int pinCode = int.Parse(PinCode_TextBox.Text);
            int TelephoneNo = int.Parse(TelephoneNo_TextBox.Text);
            control.AddEmployee(firstName, lastName, pinCode, TelephoneNo);
        }
    }
}
