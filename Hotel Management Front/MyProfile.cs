﻿using Hotel_System_Front.User_Control;

namespace Hotel_System_Front
{
    public partial class MyProfile : Form
    {
        private UC_MyProfile uc;
        Client client ;
        public MyProfile(Client client)
        {
            InitializeComponent();
            this.client = client;
            uc = new UC_MyProfile(client);
            addUserControl(uc);
            
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Parent = this;
            userControl.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uc_ProfileRooms uc = new Uc_ProfileRooms(client);
            addUserControl(uc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_ProfileReservation uc = new UC_ProfileReservation();
            addUserControl(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_ProfileFeedback uc = new UC_ProfileFeedback();
            addUserControl(uc);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login secondForm = new Login();
            secondForm.ShowDialog();
            this.Show();
        }
    }
}
