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
    public partial class CategorieManage : Form
    {
        string cs;
        SqlConnection cn;
        SqlCommand com;
        DataSet ds = new DataSet();
        SqlDataAdapter daCat;
        BindingSource bsCat = new BindingSource();
        SqlCommandBuilder cb;

        public CategorieManage()
        {
            InitializeComponent();
        }

        private void CategorieManage_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            cn = new SqlConnection(cs);
            com = new SqlCommand("Select * from categories", cn);
            daCat = new SqlDataAdapter(com);
            daCat.Fill(ds, "categories");
            cb = new SqlCommandBuilder(daCat);

            bsCat.DataSource = ds;
            bsCat.DataMember = "categories";

            listBox1.DataSource = bsCat;
            listBox1.DisplayMember = "catName";
            listBox1.ValueMember = "IdCat";

            txtName.DataBindings.Add("Text", bsCat, "catName");
            activate(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                bsCat.MoveFirst();
            else
                bsCat.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bsCat.MoveLast();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                bsCat.MoveLast();
            else
                bsCat.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsCat.MoveFirst();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bsCat.AddNew();
            activate(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this category?","Delete category",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                bsCat.RemoveCurrent();
                daCat.Update(ds, "categories");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            activate(false);
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

            btnCancel.Visible = !v;
            btnValidate.Visible = !v;
            txtName.Enabled = !v;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            bsCat.EndEdit();
            daCat.Update(ds, "categories");
            activate(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsCat.CancelEdit();
            activate(true);
        }
    }
}
