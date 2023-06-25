using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Dohune
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();            
        }


        private void airButton1_Click(object sender, EventArgs e)
        {
            form2 = new Form2("포장");
            this.Visible = false;
            form2.ShowDialog();
            
        }

        private void airButton2_Click(object sender, EventArgs e)
        {
            form2 = new Form2("매장");
            this.Visible = false;
            form2.ShowDialog();            
        }
    }
}
