using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seller
{
    public partial class SellerForm : Form
    {
        string user;
        public SellerForm()
        {
            InitializeComponent();
            panelUpdate.Hide();
            panelItemDetails.Hide();
            panelNewItem.Hide();
            user = "1";

        }

        private void Home_hmp_Click(object sender, EventArgs e)
        {

        }

        
        private void SubmitNp_Click(object sender, EventArgs e)
        {
            Seller new1 = new Seller();
            new1.Insert(user, txtNameNew, cbSizeNew, txtQuantityNew);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            panelUpdate.Hide();
            panelItemDetails.Hide();
            panelNewItem.Show();
            panel_seller.Hide();
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            panelUpdate.Show();
            panelItemDetails.Hide();
            panelNewItem.Hide();
            panelUpIt.Hide();
            txtItemId.ResetText();
            txtQuantityUp.ResetText();
            panel_seller.Hide();
        }

       

        private void BtnView_Click(object sender, EventArgs e)
        {
            panelUpdate.Hide();
            
            panelNewItem.Hide();
            panelItemDetails.Show();

            Seller v = new Seller();
            v.View(user, dgItemDetails);
        }

        string itemid;
       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string q = txtQuantityUp.Text;
            Seller up = new Seller();
            up.Update(q,itemid);
            panelUpdate.Hide();
            panel_seller.Show();
        }

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {
            itemid = txtItemId.Text;
            lblName.Text = "";
            lblSize.Text = "";
            Seller info = new Seller();
            info.GetInfo(lblName, lblSize, itemid);
            if (!string.IsNullOrEmpty(lblName.Text))
            {
                panelUpIt.Show();
            }
            else
            {
                panelUpIt.Hide();
            }
        }

        private void txtItemId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
               
            
        }

        private void btnBackUP_Click(object sender, EventArgs e)
        {
            panel_seller.Show();
            panelUpdate.Hide();
        }

        private void btnBackDetails_Click(object sender, EventArgs e)
        {
            panel_seller.Show();
            panelItemDetails.Hide();

        }

        private void btnBackNew_Click(object sender, EventArgs e)
        {
            panel_seller.Show();
            panelNewItem.Hide();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBackUP_Click_1(object sender, EventArgs e)
        {
            panelUpdate.Hide();
            panel_seller.Show();


        }
    }
}
