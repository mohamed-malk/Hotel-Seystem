using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_System.Models;
using Hotel_System.Services;

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
