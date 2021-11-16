using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cart
{
    class CurrentCart
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\c#_project\application\cart\db\cart.mdf;Integrated Security=True;Connect Timeout=30");

        public  int ItemCount()
        {
            int no=0;
            string cart = "SELECT COUNT(ID) FROM CART ";
            SqlCommand cmd = new SqlCommand(cart, con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                no=read.GetInt32(0);
            }
            if(no==0)
            {
                no = 0;
            }
            con.Close();
            return no;
            
        }

        public int Total()
        {
            int tot=0;
            string sum = "SELECT SUM(PRICE) FROM CART";
            SqlCommand cmd2 = new SqlCommand(sum, con);
            con.Open();
           try{
                SqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    tot = read2.GetInt32(0);
                } 
            }
            catch(Exception)
            {
                tot = 0;
            }
           
            con.Close();
            return tot;
        }

       
        public void Item1(Panel pnl)
        {
            string itname = "";
            int itcost=0;
            string cart = "SELECT NAME,PRICE FROM CART WHERE ID='1' ";
            SqlCommand cmdIt = new SqlCommand(cart, con);
            con.Open();
            SqlDataReader read = cmdIt.ExecuteReader();
            while (read.Read())
            {
                itname = read.GetString(0);
                itcost = read.GetInt32(1);
            }
            if (string.IsNullOrEmpty(itname))
            {
                pnl.Hide();
                
            }
            else
            {
                Form1.crt.labelItemName1.Text = itname;
                Form1.crt.labelCost1.Text = Convert.ToString(itcost);
                pnl.Show();
               
            }
            con.Close();
        }
        public void Item2(Panel pnl)
        {
            string itname = "";
            int itcost = 0;
            string cart = "SELECT NAME,PRICE FROM CART WHERE ID='2' ";
            SqlCommand cmdIt = new SqlCommand(cart, con);
            con.Open();
            SqlDataReader read = cmdIt.ExecuteReader();
            while (read.Read())
            {
                itname = read.GetString(0);
                itcost = read.GetInt32(1);
            }
            if (string.IsNullOrEmpty(itname))
            {
                pnl.Hide();
            }
            else
            {
                Form1.crt.labelItemName2.Text = itname;
                Form1.crt.labelCost2.Text = Convert.ToString(itcost);
                pnl.Show();
                
            }
            con.Close();
        }
        public void Item3(Panel pnl)
        {
            string itname = "";
            int itcost = 0;
            string cart = "SELECT NAME,PRICE FROM CART WHERE ID='3' ";
            SqlCommand cmdIt = new SqlCommand(cart, con);
            con.Open();
            SqlDataReader read = cmdIt.ExecuteReader();
            while (read.Read())
            {
                itname = read.GetString(0);
                itcost = read.GetInt32(1);
            }
            if (string.IsNullOrEmpty(itname))
            {
                pnl.Hide();
            }
            else
            {
                Form1.crt.labelItemName3.Text = itname;
                Form1.crt.labelCost3.Text = Convert.ToString(itcost);
                pnl.Show();
                
            }
            con.Close();
        }
        public void Item4(Panel pnl)
        {
            string itname = "";
            int itcost = 0;
            string cart = "SELECT NAME,PRICE FROM CART WHERE ID='4' ";
            SqlCommand cmdIt = new SqlCommand(cart, con);
            con.Open();
            SqlDataReader read = cmdIt.ExecuteReader();
            while (read.Read())
            {
                itname = read.GetString(0);
                itcost = read.GetInt32(1);
            }
            if (string.IsNullOrEmpty(itname))
            {
                pnl.Hide();
            }
            else
            {
                Form1.crt.labelItemName4.Text = itname;
                Form1.crt.labelCost4.Text = Convert.ToString(itcost);
                pnl.Show();
            }
            con.Close();
        }
        public void Item5(Panel pnl)
        {
            string itname = "";
            int itcost = 0;
            string cart = "SELECT NAME,PRICE FROM CART WHERE ID='5' ";
            SqlCommand cmdIt = new SqlCommand(cart, con);
            con.Open();
            SqlDataReader read = cmdIt.ExecuteReader();
            while (read.Read())
            {
                itname = read.GetString(0);
                itcost = read.GetInt32(1);
            }
            if (string.IsNullOrEmpty(itname))
            {
                pnl.Hide();
            }
            else
            {
                Form1.crt.labelItemName5.Text = itname;
                Form1.crt.labelCost5.Text = Convert.ToString(itcost);
                pnl.Show();
            }
            con.Close();
        }


        //Delete -------------------------------------------------------------------------------------
        public void Del(string id)
        {


            
            string cart = "DELETE FROM CART WHERE ID='"+id+"' ";
            SqlCommand cmddel = new SqlCommand(cart, con);
            con.Open();
            cmddel.ExecuteNonQuery();
            con.Close();
            string tablec = " CREATE TABLE TEMPORY(ID INT IDENTITY(1,1) PRIMARY KEY,NAME VARCHAR(50),PRICE INT)";
            SqlCommand tbl = new SqlCommand(tablec, con);
            con.Open();
            tbl.ExecuteNonQuery();
            con.Close();
            //transfer
            string transfer = "INSERT INTO TEMPORY(NAME,PRICE) SELECT NAME,PRICE FROM CART";
            SqlCommand tbt= new SqlCommand(transfer, con);
            con.Open();
            tbt.ExecuteNonQuery();
            con.Close();

            string drop1 = "DROP TABLE CART";
            SqlCommand dr1 = new SqlCommand(drop1, con);
            con.Open();
            dr1.ExecuteNonQuery();
            con.Close();

            string rename = "sp_rename 'TEMPORY', 'CART'";
            SqlCommand re = new SqlCommand(rename, con);
            con.Open();
            re.ExecuteNonQuery();
            con.Close();

            
        }


    }
}
