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
    public partial class ClientManage : Form
    {
        string cs;
        SqlConnection cn;
        SqlCommand com;
        DataSet ds = new DataSet();
        SqlDataAdapter daClient;
        BindingSource bsClient = new BindingSource();
        SqlCommandBuilder cb;

        public ClientManage()
        {
            InitializeComponent();
        }

        private void ClientManage_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            cn = new SqlConnection(cs);
            com = new SqlCommand("select * from Users", cn);
            daClient = new SqlDataAdapter(com);
            daClient.Fill(ds, "users");
            cb = new SqlCommandBuilder(daClient);

            bsClient.DataSource = ds;
            bsClient.DataMember = "Users";

            listBox1.DataSource = bsClient;
            listBox1.DisplayMember = "UserName";
            listBox1.ValueMember = "IdUser";

            txtFN.DataBindings.Add("Text", bsClient, "FirstName");
            txtLN.DataBindings.Add("Text", bsClient, "LastName");
            txtUN.DataBindings.Add("Text", bsClient, "UserName");
            txtpass.DataBindings.Add("Text", bsClient, "password");
            txtAdr.DataBindings.Add("Text", bsClient, "adresse");
            txtmail.DataBindings.Add("Text", bsClient, "email");
            txtTel.DataBindings.Add("Text", bsClient, "tel");

            activate(true);
        }

       

        private void activate(Boolean v)
        {
            listBox1.Enabled = v;
            btnFirst.Enabled = v;
            btnLast.Enabled = v;
            btnNext.Enabled = v;
            btnPrevious.Enabled = v;
            btnDelete.Visible = v;
            btnEdit.Visible = v;
            btnAdd.Visible = v;

            btncCancel.Visible = !v;
            btnValidate.Visible = !v;
            panel1.Enabled = !v;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsClient.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                bsClient.MoveLast();
            else
                bsClient.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                bsClient.MoveFirst();
            else
                bsClient.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bsClient.MoveLast();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            activate(false);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            bsClient.EndEdit();
            daClient.Update(ds, "Users");
            activate(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bsClient.RemoveCurrent();
                daClient.Update(ds, "Users");
            }
        }

        private void btncCancel_Click(object sender, EventArgs e)
        {
            bsClient.CancelEdit();
            activate(true);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bsClient.AddNew();
            activate(false);
        }
    }
}
