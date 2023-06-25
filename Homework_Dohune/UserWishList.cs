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
    public partial class UserWishList : Form
    {
        UserReceipt userReceipt;

        List<int> bugerNameList = new List<int>();
        List<string> drinkNameList = new List<string>();
        List<string> dessertNameList = new List<string>();

        public UserWishList()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("test");
        }

        public UserWishList(UserReceipt data)
        {
            InitializeComponent();
            userReceipt = data;
            totalPrice.Text = "가격: "+data.price.ToString();
            setListBoxData(data);
        }

        private void setListBoxData(UserReceipt data) 
        {
            if(data.whereEat != null) 
            {
                checkedListBox1.Items.Add(data.whereEat);
                checkedListBox1.SetItemCheckState(0, CheckState.Indeterminate);
                int count = 1;
                foreach (var buger in data.bugerList)
                {
                    if (buger.setOrsingle == "set")
                    {
                        checkedListBox1.Items.Add(buger.bugerName + "(" + buger.setOrsingle + ")" + "- " + buger.setDrink + " - " + buger.setSide);                        
                    }
                    else
                    {
                        checkedListBox1.Items.Add(buger.bugerName + "(" + buger.setOrsingle + ")");
                    }
                    bugerNameList.Add(count);
                    count++;
                }
                foreach(var drink in data.drink)
                {
                    checkedListBox1.Items.Add(drink);
                    drinkNameList.Add(drink);
                }
                foreach(var dessert in data.dessert)
                {
                    checkedListBox1.Items.Add(dessert);
                    dessertNameList.Add(dessert);
                }
            }            
        }

        private void foreverButton1_Click(object sender, EventArgs e)
        {
            for(var itemIndex = checkedListBox1.Items.Count - 1;itemIndex >= 1;itemIndex--)
            {
                
                if (checkedListBox1.GetItemChecked(itemIndex))
                {
                    string checkName = checkedListBox1.GetItemText(checkedListBox1.Items[itemIndex]);
                    if(bugerNameList.Contains(itemIndex))
                    {
                        userReceipt.price -= new ReceiptHelpers().bugerPrice(userReceipt.bugerList[itemIndex].bugerName, userReceipt.bugerList[itemIndex].setOrsingle);
                        userReceipt.bugerList.RemoveAt(itemIndex-1);
                        checkedListBox1.Items.RemoveAt(itemIndex);
                    }
                    else if(drinkNameList.Contains(checkName))
                    {
                        userReceipt.price -= new ReceiptHelpers().drinkPrice(checkName);
                        userReceipt.drink.Remove(checkName);
                        checkedListBox1.Items.RemoveAt(itemIndex);
                    }
                    else if(dessertNameList.Contains(checkName))
                    {
                        userReceipt.price -= new ReceiptHelpers().dessertPrice(checkName);
                        userReceipt.dessert.Remove(checkName);
                        checkedListBox1.Items.RemoveAt(itemIndex);
                    }
                    totalPrice.Text = "가격: " + userReceipt.price.ToString();
                }
            }
            
        }

        private void foreverButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form2(userReceipt).ShowDialog();
        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
