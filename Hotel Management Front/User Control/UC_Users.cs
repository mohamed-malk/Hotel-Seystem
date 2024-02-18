using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
            comboBox1.Items.Add("Famael,f");
            comboBox1.Items.Add("male,m");
        }
        EmployeeRepo employee = new EmployeeRepo();

        private void button1_Click(object sender, EventArgs e)
        {
            string Nid = textBox4.Text;
            string name = textBox1.Text;
            string username = textBox3.Text;
            string password = textBox2.Text;
            string email = textBox5.Text;
            int age = int.Parse(textBox8.Text);
            int attend = int.Parse(textBox10.Text);
            string Address = textBox6.Text;
            float salary = float.Parse(textBox7.Text);

            bool gender = comboBox1.Text == "Famael,f" ? true : false;

            Person emp = new Employee()
            {

                Name = name,
                NId = Nid,
                Address = Address,
                Age = age,
                Email = email,
                Gender = gender,
                UserName = username,
                Password = password,
                Attend = attend,
                Salary = salary
                // Nationality = nationaltiy
            };
            //   employee.CreateManager(emp); ;
            //ClientRepo ClientRepo = new ClientRepo();

            dataGridView1.DataSource = new List<Person> { emp };
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {

        }
    }
}
