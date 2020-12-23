using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10 {
    public partial class View : Form {
		Controller controller = new Controller();
		public View() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
			string text1 = textBox1.Text.Trim();
			string text2 = textBox2.Text.Trim();
			double res;
			res = controller.Handler(text1, text2);
			label2.Text = res.ToString();
		}
    }
    class Controller {
		Model model = new Model();
		public double Handler(string t1, string t2) {
			int a = 0, b = 0;
			if (!string.IsNullOrEmpty(t1) && !string.IsNullOrEmpty(t2)) {
				try {
					a = Convert.ToInt32(t1);
					b = Convert.ToInt32(t2);
				}
				catch (Exception exc) { }
			}
			return model.Calculate(a, b);
		}
	}
	class Model {
		public double Calculate(int a, int b) {
			double res = 1;
			if (b >= 0) {
				for (int i = 0; i < b; ++i) {
					res *= a;
				}
			}
			else {
				if (a == 0) {
					res = -1;
				}
				else {
					for (int i = 0; i < b * -1; ++i) {
						res /= a;
					}
				}
			}
			return res;
		}
	}
}