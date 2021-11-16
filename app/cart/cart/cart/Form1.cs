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

namespace cart
{
    public partial class Form1 : Form
    {
        public static Form1 crt;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heesh\Desktop\cart\db\cart.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
            CurrentCart c = new CurrentCart();

            labelItemNo.Text = Convert.ToString(c.ItemCount());
            labelTotal.Text = Convert.ToString(c.Total());

            panelItems.Hide();
            crt = this;

        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            CheckOut();
            string tot = labelTotal.Text;
            if(tot=="0")
            {
                MessageBox.Show("No Items Selected To Check Out");
                panelItems.Hide();
            }
            else
            {
                panelItems.Show();
            }
        }

        public void CheckOut()
        {
           
            
            CurrentCart chekout = new CurrentCart();
           
            chekout.Item1(panelItem1);
            chekout.Item2(panelItem2);
            chekout.Item3(panelItem3);
            chekout.Item4(panelItem4);
            chekout.Item5(panelItem5);
            
        }
        CurrentCart del = new CurrentCart();
        private void buttonRemove1_Click(object sender, EventArgs e)
        {
            
            string id = "1";
            del.Del(id);
            CheckOut();
            labelItemNo.Text = Convert.ToString(del.ItemCount());
            labelTotal.Text = Convert.ToString(del.Total());
            if (labelItemNo.Text == "0")
            {
                
                panelItems.Hide();
            }

        }

        private void buttonRemove2_Click(object sender, EventArgs e)
        {
            
            string id = "2";
            del.Del(id);
            CheckOut();
            labelItemNo.Text = Convert.ToString(del.ItemCount());
            labelTotal.Text = Convert.ToString(del.Total());
        }

        private void buttonRemove3_Click(object sender, EventArgs e)
        {
            
            string id = "3";
            del.Del(id);
            CheckOut();
            labelItemNo.Text = Convert.ToString(del.ItemCount());
            labelTotal.Text = Convert.ToString(del.Total());
        }

        private void buttonRemove4_Click(object sender, EventArgs e)
        {
           
            string id = "4";
            del.Del(id);
            CheckOut();
            labelItemNo.Text = Convert.ToString(del.ItemCount());
            labelTotal.Text = Convert.ToString(del.Total());
        }


        private void buttonRemove5_Click(object sender, EventArgs e)
        {
            string id = "4";
            del.Del(id);
            CheckOut();
            labelItemNo.Text = Convert.ToString(del.ItemCount());
            labelTotal.Text = Convert.ToString(del.Total());
        }
    }


        
    }

