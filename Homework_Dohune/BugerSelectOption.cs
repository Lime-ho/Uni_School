using Homework_Dohune.Helpers;
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
    public partial class BugerSelectOption : Form
    {
        UserReceipt userReceipt;

        public BugerSelectOption()
        {
            InitializeComponent();
        }

        public BugerSelectOption(string name,UserReceipt data)
        {
            InitializeComponent();
            bugerName.Text = name;
            userReceipt = data;
        }

        private void singleRadio_CheckedChanged(object sender)
        {
            if(singleRadio.Checked) 
            {
                cokeRadio.Enabled = false;
                americanoRadio.Enabled = false;
                shakeRadio.Enabled = false;
                potatoRadio.Enabled = false;
                cheezeRadio.Enabled = false;
            }
            else 
            {
                cokeRadio.Enabled = true;
                americanoRadio.Enabled = true;
                shakeRadio.Enabled = true;
                potatoRadio.Enabled = true;
                cheezeRadio.Enabled = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form2(userReceipt).ShowDialog();
        }

        private void bugerAdd_Click(object sender, EventArgs e)
        {
            Buger buger = new Buger();
            buger.bugerName = bugerName.Text;
            if (singleRadio.Checked)
            {                
                buger.setOrsingle = "single";                
            }
            else
            {
                buger.setOrsingle = "set";
                if (cokeRadio.Checked) { buger.setDrink = "콜라"; }
                else if(americanoRadio.Checked) { buger.setDrink = "아메리카노"; }
                else if(shakeRadio.Checked) { buger.setDrink = "바닐라쉐이크"; }
                if (potatoRadio.Checked) { buger.setSide = "감자튀김"; }
                else if(cheezeRadio.Checked) { buger.setSide = "치즈스틱"; }                
            }
            userReceipt.bugerList.Add(buger);
            userReceipt.price += new ReceiptHelpers().bugerPrice(buger.bugerName,buger.setOrsingle);
            this.Visible = false;
            new Form2(userReceipt).ShowDialog();
        }
    }
}
