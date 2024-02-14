using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_Clients : UserControl
    {
        public UC_Clients()
        {
            InitializeComponent();
            comboBox1.Items.Add("Famael,f");
            comboBox1.Items.Add("male,m");
        }
        ClientRepo client = new ClientRepo();
        private void button1_Click(object sender, EventArgs e)
        {
            string Nid = textBox6.Text;
            string name = textBox4.Text;
            string username = textBox1.Text;
            string password = textBox5.Text;
            string email = textBox3.Text;
            //string phone = textBox2.Text;
            string Address = address.Text;
            int age = int.Parse(Age.Text);



            bool gender = comboBox1.Text == "Famael,f" ? true : false;
            //membership
            string nationaltiy = Nationality.Text;
            Person cl = new Client()
            {
                Name = name,
                NId = Nid,
                Address = Address,
                Age = age,
                Email = email,
                Gender = gender,
                UserName = username,
                Password = password,
                Nationality = nationaltiy
            };
            client.Add(cl); ;
            //ClientRepo ClientRepo = new ClientRepo();

            dataGridView1.DataSource = new List<Person> { cl};
        }
    }
}
