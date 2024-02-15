using Hotel_System_Back.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_Rooms : UserControl
    {
        public UC_Rooms()
        {
            InitializeComponent();
            comboBox2.Items.Add("True");
            comboBox2.Items.Add("False");
            comboBox1.Items.Add("Single");
            comboBox1.Items.Add("Double");
            comboBox1.Items.Add("Trible");
        }
        RoomRepo room = new RoomRepo();
        private void button1_Click(object sender, EventArgs e)
        {
            //  int id = itextBox1.Text();
            //    int Id =
            RoomType type;
            int Number = int.Parse(textBox1.Text);
            int Rate = int.Parse(textBox2.Text);

            
            if(comboBox1.Text == "Single")
            {
                type = RoomType.Single;

            }
            else if(comboBox1.Text == "Double") 
            {
                type = RoomType.Double;
            }

            else
            {
                type = RoomType.Triple;
            }

          //  RoomType type2 = (RoomType)Enum.Parse(typeof(RoomType), type);
            
           
            bool IsAvailable = comboBox2.Text == "False" ? false : true;
            Room r = new Room()
            {
                Number = Number,
                Rate = Rate,
                Type = type,
                IsAvailable = IsAvailable
                
            };
            room.Add(r); ;
            //ClientRepo ClientRepo = new ClientRepo();

            dataGridView1.DataSource = new List<Room> { r };
        }
    }

}
