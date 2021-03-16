using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CafeManagementNH
{
    public partial class AdminPage : Form
    {
        private string _username;

        public AdminPage()
        {
            InitializeComponent();
        }

        public AdminPage(string UserName)
        {
            InitializeComponent();
            _username = UserName;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello " + _username + " !";
            lblUser.Text = "Welcome " + _username + " !";
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnItem.Height;
            sidePanel.Top = btnItem.Top;
            ItemManage i = new ItemManage();
            i.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnClient.Height;
            sidePanel.Top = btnClient.Top;

            ClientManage c = new ClientManage();
            c.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnOrder.Height;
            sidePanel.Top = btnOrder.Top;
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnCat.Height;
            sidePanel.Top = btnCat.Top;

            CategorieManage c = new CategorieManage();
            c.ShowDialog();
        }

        

        private void btnLog_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
           // lblUser.Text = Form1.txtName.text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }
    }
}
