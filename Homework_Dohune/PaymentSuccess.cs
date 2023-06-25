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
    public partial class PaymentSuccess : Form
    {
        public PaymentSuccess()
        {
            InitializeComponent();
        }

        private void successButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
