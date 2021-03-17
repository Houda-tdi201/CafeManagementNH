using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementNH
{
    public partial class ClientPage : Form
    {
        private string _username;

        public ClientPage()
        {
            InitializeComponent();
        }
        public ClientPage(string UserName)
        {
            InitializeComponent();
            _username = UserName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            lblHello.Text="Hello "+_username+" !";
            lblUser.Text = "Welcome " + _username + " !";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnProfil.Height;
            sidePanel.Top = btnProfil.Top;

            
            Profil p = new Profil(_username);
            p.ShowDialog();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnOrder.Height;
            sidePanel.Top = btnOrder.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
    }
}
