using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dop {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e) {
            System.Windows.Forms.Button btn;
            if (sender is System.Windows.Forms.Button) {
                btn = (System.Windows.Forms.Button)sender;
                int x = btn.Location.X;
                int y = btn.Location.Y;
                int dx = rand.Next(-10, 10);
                int dy = rand.Next(-10, 10);
                int fh = this.ClientSize.Height;
                int fw = this.ClientSize.Width;
                int bh = this.button1.Height;
                int bw = this.button1.Width;
                if (x + dx >= 0 && y + dy >= 0 && y + bh + dy <= fh && x + bw + dx <= fw) {
                    btn.Location = new System.Drawing.Point(x + dx, y + dy);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            textBox1.PasswordChar = '*';
            label1.Text = textBox1.Text;
        }
    }
}
