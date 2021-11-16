using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TD
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DILSHAN\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassoword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassoword.Focus();
                return;
            }
            string un = txtUserName.Text;
            string ps = txtPassoword.Text;
            try
            {
                string q = "SELECT Password,Type FROM REGISTRATION WHERE Name='" + un + "'";
                SqlCommand comd = new SqlCommand(q, con);
                con.Open();
                SqlDataReader result = comd.ExecuteReader();

                string tbpass = "";
                string type = "";

                while(result.Read())
                {
                    tbpass = result["PASSWORD"].ToString();
                    type = result["TYPE"].ToString();
                }




               

                if (tbpass.Equals(ps))
                {
                    MessageBox.Show("You have logged in successfully " + un);
                    //Hide the login form
                    this.Hide();

                    if(type.Equals("Seller"))
                    {
                        
                        //open seller form
                    }

                    if (type.Equals("Buyer"))
                    {
                        //open buyer form
                    }
                }
                

                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassoword.Clear();
                    txtUserName.Focus();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
