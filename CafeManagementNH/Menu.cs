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
    public partial class Menu : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter daCat;
        BindingSource bsCat = new BindingSource();
        SqlDataAdapter daItem;
        BindingSource bsItem = new BindingSource();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            //string qry = " Select * from categories";
            //SqlCommand com = new SqlCommand(qry, cn);
            //daCat = new SqlDataAdapter(com);
            //daCat.Fill(ds, "categories");

            //bsCat.DataSource = ds;
            //bsCat.DataMember = "categories";

            //cbCat.DataSource = bsCat;
            //cbCat.DisplayMember = "CatName";
            //cbCat.ValueMember = "IdCat";


            SqlCommand com2 = new SqlCommand("Select idItem,itemName,priceItem,IdCat from items", cn);
            daItem = new SqlDataAdapter(com2);
            daItem.Fill(ds, "items");


            //DataColumn CatIdcat = ds.Tables["categories"].Columns["IdCat"];
            //DataColumn ItemIdCat = ds.Tables["items"].Columns["IdCat"];

            //DataRelation relCatItem = new DataRelation("fk_cat_item", CatIdcat, ItemIdCat);
            //ds.Relations.Add(relCatItem);

            bsItem.DataSource = ds;
            bsItem.DataMember = "items";

            dataGridView1.DataSource = bsItem;
            dataGridView1.Columns["idItem"].Visible = false;
            dataGridView1.Columns["IdCat"].Visible = false;
            dataGridView1.Columns["itemName"].HeaderText = "Name";
            dataGridView1.Columns["itemName"].Width= 200;
            dataGridView1.Columns["priceitem"].HeaderText = "Price";
            dataGridView1.Columns["priceitem"].Width = 155;

            try
            {
                label4.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
            chargeInfo();
        }

        private void chargeInfo()
        {
            string cs = ConfigurationManager.ConnectionStrings["CafeManagementNH.Properties.Settings.cafeManagementNHConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand com3 = new SqlCommand("Select * from items where idItem=@id", cn);
            com3.Parameters.AddWithValue("@id", label4.Text);
            SqlDataReader dr = com3.ExecuteReader();

            while (dr.Read())
            {
                lblName.Text = dr["itemName"].ToString();
                lblDes.Text = dr["description"].ToString();
                try
                {
                    photo.Load("photos/" + dr["photo"].ToString());
                }
                catch
                {
                    photo.Load("photos/vide.jpg");
                }
            }
            dr.Close();
            dr = null;
            com3 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            chargeInfo();
        }

        
    }
}
