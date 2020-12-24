using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            decimal value = numericUpDown1.Value; 
            Singleton message = Singleton.getInstance(value);
            System.Windows.Forms.MessageBox.Show(message.GetHashCode().ToString(), message.number.ToString());
        }
    }
    class Singleton {
        private static Singleton instance;
        public decimal number { get; private set; }
        private Singleton(decimal a) {
            this.number = a;
        }
        public static Singleton getInstance(decimal a) {
            if (instance == null)
                instance = new Singleton(a);
            return instance;
        }
    }
}