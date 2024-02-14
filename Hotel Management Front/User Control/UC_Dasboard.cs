using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
namespace Hotel_System_Front.User_Control
{
    public partial class UC_Dasboard : UserControl
    {
        Employee _employee;
        public UC_Dasboard(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

   
    }
}
