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

namespace TD
{
    public partial class Registraton : Form
    {    

        public Registraton()
        {
            InitializeComponent();

            
        }

        string type;
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(type))
            {
                return;
            }




            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DILSHAN\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("insert into REGISTRATION(Name,Address,Contact,Password,Type) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + type + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successfully!");



                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Registration problem");
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
           
            if (checkBox2.Checked)
            {
                
                type = "Seller";
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
          

            if (checkBox1.Checked)
            {
                
                type = "Customer";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
