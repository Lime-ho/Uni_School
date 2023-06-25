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
using static Homework_Dohune.Form1;

namespace Homework_Dohune
{
    public partial class Form2 : Form
    {
        UserReceipt userRecipt = new UserReceipt();

        public Form2()
        {
            InitializeComponent();
            userRecipt.whereEat = "포장";
        }

        public Form2(string data)
        {
            InitializeComponent();
            userRecipt.whereEat = data;
            userRecipt.bugerList = new List<Buger>();
            userRecipt.price = 0;
            userRecipt.drink = new List<string>();
            userRecipt.dessert = new List<string>();
        }

        public Form2(UserReceipt data)
        {
            InitializeComponent();
            userRecipt = data;
        }
        private void paymentButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new UserPayment(userRecipt).ShowDialog();                       
        }

        private void menuListButton_Click(object sender, EventArgs e)
        {
            UserWishList userWishList = new UserWishList(userRecipt);
            this.Visible = false;
            userWishList.ShowDialog();
        }

        private void dreamTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void cheezeBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("치즈버거", userRecipt).ShowDialog();
        }

        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void aloneTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void aloneTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chickenBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("치킨버거", userRecipt).ShowDialog();
        }

        private void shanghaiBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("상하이버거", userRecipt).ShowDialog();
        }

        private void shrimpBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("새우버거", userRecipt).ShowDialog();
        }

        private void quarterBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("더블쿼터버거", userRecipt).ShowDialog();
        }

        private void tomatoBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("베이컨토마토버거", userRecipt).ShowDialog();
        }

        private void bigmacBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("빅맥버거", userRecipt).ShowDialog();
        }

        private void buger1955_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("1955버거", userRecipt).ShowDialog();
        }

        private void bulgogiBuger_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new BugerSelectOption("불고기버거", userRecipt).ShowDialog();
        }

        private void shakeDrink_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().drinkPrice("바닐라쉐이크");
            userRecipt.drink.Add("바닐라쉐이크");
        }

        private void amricanoDrink_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().drinkPrice("아메리카노");
            userRecipt.drink.Add("아메리카노");
        }

        private void cokeDrink_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().drinkPrice("콜라");
            userRecipt.drink.Add("콜라");
        }

        private void macWing_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().dessertPrice("맥윙");
            userRecipt.dessert.Add("맥윙");
        }

        private void potatoDessert_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().dessertPrice("감자튀김");
            userRecipt.dessert.Add("감자튀김");
        }

        private void cheezeStickDessert_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().dessertPrice("치즈스틱");
            userRecipt.dessert.Add("치즈스틱");
        }

        private void macnuergetDessert_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().dessertPrice("맥너갯");
            userRecipt.dessert.Add("맥너갯");
        }

        private void metlebDessert_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().dessertPrice("비프 스낵랩");
            userRecipt.dessert.Add("비프 스낵랩");
        }

        private void chickenlebDessert_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().dessertPrice("치킨 스낵랩");
            userRecipt.dessert.Add("치킨 스낵랩");
        }

        private void orreoDessert_Click(object sender, EventArgs e)
        {
            userRecipt.price += new ReceiptHelpers().dessertPrice("오레오 맥플러리");
            userRecipt.dessert.Add("오레오 맥플러리");
        }

        private void bugerMenu_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(0);
        }

        private void drinkMenu_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(1);
        }

        private void dessertMenu_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(2);
        }

        private void menuCancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form1().ShowDialog();
        }
    }
}
