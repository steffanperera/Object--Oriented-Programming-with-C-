using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        //back button
        static Form1 _obj;


        public static Form1 Instance
        {

            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }


        public Panel pnlcontainer
        {
            get { return panelController; }
            set { panelController = value; }
        }

        public Button bkbutton
        {
            get { return backbutton; }
            set { backbutton = value; }
        }



        public Form1()
        {
            InitializeComponent();

           //side pannel & homepage
            SidePannel.Height = button4.Height;
            SidePannel.Top = button4.Top;
            proHome1.BringToFront();
            //hide the sub menu
            custumerdesign();
           

        }



        //Sub menu pannel show and hide

        private void custumerdesign()
        {
            submenupanel.Visible = false;
        }

        private void hidesubmenu()
        {
            if (submenupanel.Visible == true)
                submenupanel.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        //back button
        private void Form1_Load(object sender, EventArgs e)
        {
            backbutton.Visible = false;
            _obj = this;

            ProHome PH = new ProHome();
            PH.Dock = DockStyle.Fill;
            panelController.Controls.Add(PH);

        }

        // for the close lable (X)
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //home page 
        private void button4_Click(object sender, EventArgs e)
        {
            SidePannel.Height = button4.Height;
            SidePannel.Top = button4.Top;
            proHome1.BringToFront();

            hidesubmenu();
        }

        //categories
        private void button5_Click(object sender, EventArgs e)
        {
            SidePannel.Height = button5.Height;
            SidePannel.Top = button5.Top;
            proCategory1.BringToFront();

            showsubmenu(submenupanel);
        }

        //back button onclick
        private void backbutton_Click(object sender, EventArgs e)
        {
            panelController.Controls["prohome"].BringToFront();
            backbutton.Visible = false;
        }

        //about
        private void button7_Click_1(object sender, EventArgs e)
        {
            SidePannel.Height = button7.Height;
            SidePannel.Top = button7.Top;
            proAbout1.BringToFront();

            hidesubmenu();
        }

        //category t-shirt 
        private void button1_Click(object sender, EventArgs e)
        {
            proCtshirt1.BringToFront();

           
        }

        //category trousers
        private void button3_Click(object sender, EventArgs e)
        {
            proCtrousers1.BringToFront();

        }

        //category blouse
        private void button11_Click(object sender, EventArgs e)
        {
            proCblouse1.BringToFront();
        }


        //category jackets
        private void button12_Click(object sender, EventArgs e)
        {
            proCjackets1.BringToFront();
        }

        //category shoues
        private void button13_Click(object sender, EventArgs e)
        {
            proCshoues1.BringToFront();
        }

        //category hats
        private void button14_Click(object sender, EventArgs e)
        {
            proChats1.BringToFront();
        }
    }
}