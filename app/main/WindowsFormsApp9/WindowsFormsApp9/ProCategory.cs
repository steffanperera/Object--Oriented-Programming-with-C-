using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class ProCategory : UserControl
    {
        public ProCategory()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        /*
        private void button1_Click(object sender, EventArgs e)
        {
            ProCtshirt t1 = new ProCtshirt();
            t1.Show();

        }

        */

        //to open a user form from a user form (categories view more button)


        /*
         * private void button1_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.pnlcontainer.Controls.ContainsKey("ProcategoryTshirt"))
            {
                ProcategoryTshirts un = new ProcategoryTshirts();
                un.Dock = DockStyle.Fill;
                Form1.Instance.pnlcontainer.Controls.Add(un);
            }

            Form1.Instance.pnlcontainer.Controls["ProcategoryTshirt"].BringToFront();
            Form1.Instance.pnlcontainer.Visible = true;
        } 
        
         */


    }
}
