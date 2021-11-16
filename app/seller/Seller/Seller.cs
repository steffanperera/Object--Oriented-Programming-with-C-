using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seller
{
    class Seller
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thaveesha\Desktop\C#Project\project.mdf;Integrated Security=True;Connect Timeout=30");


        public void Insert(string userid, TextBox name, ComboBox size, TextBox quntity)
        {
            string nameIt = name.Text;
            string sizeIt = size.Text;
            string quantityIt = quntity.Text;
            if(string.IsNullOrEmpty(nameIt))
            {
                MessageBox.Show("Enter item name");
                return;
            }
            if (string.IsNullOrEmpty(sizeIt))
            {
                MessageBox.Show("Enter item size");
                return;
            }
            if (string.IsNullOrEmpty(quantityIt))
            {
                MessageBox.Show("Enter item quantity");
                return;
            }


            try
            {
                string insertdata = "INSERT INTO ITEM(NAME,SIZE,QUNTITY,SELLER) VALUES('" + nameIt + "', '" + sizeIt + "', '" + quantityIt + "', '" + userid + "')";
                SqlCommand command = new SqlCommand(insertdata, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insertion Successfull");
            }
            catch(Exception)
            {
                MessageBox.Show("Insertion Unsuccessfull");
            }
            finally
            {
                name.ResetText();
                size.ResetText();
                quntity.ResetText();
            }
        }

        public void View(string id,DataGridView data)
        {
            string viewdata="SELECT ITEMID,NAME,QUNTITY FROM ITEM WHERE SELLER='"+id+"'";

            SqlDataAdapter read = new SqlDataAdapter(viewdata, con);

            DataSet view = new DataSet();
            read.Fill(view, "ITEM");

            data.DataSource = view.Tables["ITEM"];
            data.Hide();
            int cou = data.Rows.Count;
            if(cou>0)
            {
                data.Show();
            }
            else
            {
                MessageBox.Show("No Items To Show");
            }
        }

        public void Update(string q,string id)
        {
            string getData = "SELECT QUNTITY FROM ITEM WHERE ITEMID='" + id + "'";

            SqlCommand cmd1 = new SqlCommand(getData, con);
            con.Open();
            SqlDataReader assign = cmd1.ExecuteReader();
            string cur="";
            while (assign.Read())
            {
                cur = assign["QUNTITY"].ToString();
               
            }
            int curval = int.Parse(cur);
            int add = int.Parse(q);
            int newval = curval + add;

            string stock = Convert.ToString(newval);
            con.Close();



            try
            {
                string up = "UPDATE ITEM SET QUNTITY='" + stock + "' WHERE ITEMID='" + id + "'";
                SqlCommand cmd = new SqlCommand(up, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Item Stocked");
                
            }
            catch(Exception)
            {
                
                 MessageBox.Show("Unable Item Stocked");
            }

        }

        public void GetInfo(Label name,Label size,string itId)
        {
            string getData = "SELECT NAME,SIZE FROM ITEM WHERE ITEMID='" + itId + "'";

            try
            {

                SqlCommand cmd = new SqlCommand(getData, con);
                con.Open();
                SqlDataReader assign = cmd.ExecuteReader();

                while (assign.Read())
                {
                    name.Text = assign["NAME"].ToString();
                    size.Text = assign["SIZE"].ToString();
                }
            }
            catch(Exception)
            {

            }
            con.Close();

        }
    }
}
