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
using System.IO;

namespace CafeManagementNH
{
    public partial class ItemManage : Form
    {

        string cs;
        SqlConnection cn;
        DataSet ds = new DataSet();
        SqlCommand com1;
        SqlCommand com2;
        SqlDataAdapter daItems;
        SqlDataAdapter daCat;
        BindingSource bsItems = new BindingSource();
        BindingSource bsCat = new BindingSource();
        SqlCommandBuilder cb;


        public ItemManage()
        {
            InitializeComponent();
        }

        private void ItemManage_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            cn = new SqlConnection(cs);

            com1 = new SqlCommand("Select * from categories", cn);
            daCat = new SqlDataAdapter(com1);
            daCat.Fill(ds, "categories");

            bsCat.DataSource = ds;
            bsCat.DataMember = "categories";

            cbCat.DataSource = bsCat;
            cbCat.DisplayMember = "catName";
            cbCat.ValueMember = "IdCat";
            
            com2 = new SqlCommand("Select * from items", cn);

            daItems = new SqlDataAdapter(com2);
            daItems.Fill(ds, "items");
            cb = new SqlCommandBuilder(daItems);

            DataColumn CatIdcat = ds.Tables["categories"].Columns["IdCat"];
            DataColumn ItemIdCat = ds.Tables["items"].Columns["IdCat"];

            DataRelation relCatItem = new DataRelation("fk_cat_item", CatIdcat, ItemIdCat);
            ds.Relations.Add(relCatItem);
            
            bsItems.DataSource = bsCat;
            bsItems.DataMember = "fk_cat_item";

            listBox1.DataSource = bsItems;
            listBox1.DisplayMember = "itemName";
            listBox1.ValueMember = "IdItem";

            txtName.DataBindings.Add("Text", bsItems, "itemName");
            txtDescription.DataBindings.Add("Text", bsItems, "description");
            txtStock.DataBindings.Add("Text", bsItems, "qteStock");
            txtPrice.DataBindings.Add("Text", bsItems, "priceItem");
            txtPhoto.DataBindings.Add("Text", bsItems, "photo");

            activate(true);
            refrechPhoto();
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
            btnPhoto.Visible = !v;
            panel1.Enabled = !v;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsItems.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                bsItems.MoveLast();
            else
                bsItems.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count-1)
                bsItems.MoveFirst();
            else
                bsItems.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bsItems.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bsItems.AddNew();
            activate(false);
            lblOldPic.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            activate(false);
            lblOldPic.Text = txtPhoto.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                string photo = "photos/" + txtPhoto.Text;
                bsItems.RemoveCurrent();
                daItems.Update(ds,"items");


                try
                {
                    File.Delete(photo);
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            bsItems.EndEdit();
            daItems.Update(ds, "items");
            activate(true);

            if (lblOldPic.Text != "" && lblOldPic.Text != txtPhoto.Text)
            {
                try
                {
                    File.Delete("photos/" + lblOldPic.Text);
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void btncCancel_Click(object sender, EventArgs e)
        {
            bsItems.CancelEdit();
            activate(true);
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                string ext = Path.GetExtension(ofd.FileName);
                string name = getRandomName() + ext;
                File.Copy(ofd.FileName, "photos/" + name);
                txtPhoto.Text = name;
            }
        }

        private void refrechPhoto()
        {
            if(txtPhoto.Text==null)
            {
                pictureBox1.Load("photos/vide.jpg");
            }
            else
            {
                try
                {
                    pictureBox1.Load("photos/" + txtPhoto.Text);
                }
                catch(Exception ex) {
                    pictureBox1.Load("photos/vide.jpg");
                }
            }
        }

        private void txtPhoto_TextChanged(object sender, EventArgs e)
        {
            refrechPhoto();
        }

        private string getRandomName()
        {
            string name = DateTime.Now.ToString("ddMMyyyyhhmmss");
            Random r = new Random();
            long i = Math.Abs(r.Next() * 100000);

            return name + i;
        }


    }
}
