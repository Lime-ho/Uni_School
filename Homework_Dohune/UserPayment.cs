using Homework_Dohune.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Dohune
{
    public partial class UserPayment : Form
    {
        UserReceipt userReceipt;

        public UserPayment()
        {
            InitializeComponent();
        }

        public UserPayment(UserReceipt data)
        {
            InitializeComponent();
            userReceipt = data;            
            menuList.Items.Add(data.whereEat);
            foreach (var buger in data.bugerList)
            {
                if (buger.setOrsingle == "set")
                {
                    menuList.Items.Add(buger.bugerName + "(" + buger.setOrsingle + ")" + "- " + buger.setDrink + " - " + buger.setSide);
                }
                else
                {
                    menuList.Items.Add(buger.bugerName + "(" + buger.setOrsingle + ")");
                }
            }
            foreach (var drink in data.drink)
            {
                menuList.Items.Add(drink);
            }
            foreach (var dessert in data.dessert)
            {
                menuList.Items.Add(dessert);
            }
            menuList.Items.Add("--------------------------------");
            menuList.Items.Add("총 금액: "+data.price.ToString());
        }

        private void payRun_Click(object sender, EventArgs e)
        {
            string fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            DirectoryInfo di = Directory.CreateDirectory(@"C:\MacDohun");
            StreamWriter sw = new StreamWriter(di.FullName + @"\" + fileName+".txt");
            sw.WriteLine("영수증");
            sw.WriteLine("------------------------------");
            for(var item = 0;item < menuList.Items.Count;item++)
            {
                sw.WriteLine(menuList.GetItemText(menuList.Items[item]));
            }
            sw.WriteLine("------------------------------");
            sw.WriteLine("Made by Dohune");
            sw.Close();
            this.Visible = false;
            new PaymentSuccess().ShowDialog();
        }

        private void payCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form2(userReceipt).ShowDialog();
        }
    }
}
