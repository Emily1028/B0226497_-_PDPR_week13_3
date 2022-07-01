using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str = "";
        Random rnd = new Random();
        private void btnOK_Click(object sender, EventArgs e)
        {
            List<MEMBER> listgMEMBER = new List<MEMBER>();
            for (int i = 0; i < 10; i++)
            {
                MEMBER member = new MEMBER("oo市oo路oo巷oo號", i+1, rnd.Next(0, 100),$"段昱如_{i+1}",rnd.Next(10000000,99999999));
                str += member.MEMBERINFO();
            }
            lblRESULT.Text = str;
        }
    }
}
