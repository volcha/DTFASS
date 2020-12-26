using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            int i1 = 0, i2 = 0, i3 = 0;
            if (radioButton1.Checked)
                i1 = 1;
            else if (radioButton2.Checked)
                i1 = 2;
            else if (radioButton3.Checked)
                i1 = 3;
            if (radioButton4.Checked)
                i2 = 1;
            else if (radioButton5.Checked)
                i2 = 2;
            else if (radioButton6.Checked)
                i2 = 3;
            if (radioButton7.Checked)
                i3 = 1;
            else if (radioButton8.Checked)
                i3 = 2;
            else if (radioButton9.Checked)
                i3 = 3;
            if (i1 != 0 && i2 != 0 && i3 != 0) {
                Present present = new Present(i1);
                Packaging packaging = new Packaging(i2);
                Delivery delivery = new Delivery(i3);
                Label lab = label1;
                Facade facade = new Facade(present, packaging, delivery);
                facade.Order(lab);
            }
            else
                MessageBox.Show("Вы не отметили все пункты");
        }
    }
    class Present {
        int i;
        public Present(int n) {
            i = n;
        }
        public double Find() {
            if (i == 1)
                return 10000;
            else if (i == 2)
                return 1000;
            else
                return 2500;
        }
    }
    class Packaging {
        int i;
        public Packaging(int n) {
            i = n;
        }
        string str = "Стоимость вашего заказа ";
        public void Recolor(Label label, double price) {
            if (i == 1) {
                str += price.ToString();
                str += " рублей";
                label.Text = str;
                label.ForeColor = Color.Blue;
            }
            else if (i == 2) {
                str += price.ToString();
                str += " рублей";
                label.Text = str;
                label.ForeColor = Color.Green;
            }
            else {
                str += price.ToString();
                str += " рублей";
                label.Text = str;
                label.ForeColor = Color.Red;
            }
        }
    }
    class Delivery {
        int i;
        public Delivery(int k) {
            i = k;
        }
        public double Calculate(double price) {
            if (i == 1)
                return price;
            else if (i == 2)
                return price * 1.1;
            else
                return price * 1.05;
        }
    }
    class Facade {
        Present present;
        Delivery delivery;
        Packaging packaging;
        public Facade(Present pre, Packaging pac, Delivery del) {
            present = pre;
            delivery = del;
            packaging = pac;
        }
        public void Order(Label label) {
            double price = present.Find();
            double changedPrice = delivery.Calculate(price);
            packaging.Recolor(label, changedPrice);
        }
    }
}