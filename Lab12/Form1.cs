using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void carToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                Client fer = new Client(new Ferrari());
                MessageBox.Show(fer.CarTime());
            }
        }
        private void motorcycleToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                Client fer = new Client(new Ferrari());
                MessageBox.Show(fer.MotoTime());
            }
        }
        private void carToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                Client lam = new Client(new Lamborghini());
                MessageBox.Show(lam.CarTime());
            }
        }
        private void motorcycleToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (sender is ToolStripMenuItem) {
                Client lam = new Client(new Lamborghini());
                MessageBox.Show(lam.MotoTime());
            }
        }
    }
    abstract class Car {
        public abstract string Time();
    }
    abstract class Motorcycle {
        public abstract string Time();
    }
    class LaFerrari : Car {
        static Random rnd = new Random();
        int t = rnd.Next(15, 90);
        public override string Time() {
            string str = "Вы заказали машину модели LaFerrari. Время доставки ";
            str += t.ToString();
            str += " дней";
            return str;
        }
    }
    class Sian : Car {
        static Random rnd = new Random();
        int t = rnd.Next(15, 90);
        public override string Time() {
            string str = "Вы заказали машину модели Sian. Время доставки ";
            str += t.ToString();
            str += " дней";
            return str;
        }
    }
    class MotoFer : Motorcycle{
        static Random rnd = new Random();
        int t = rnd.Next(15, 90);
        public override string Time() {
            string str = "Вы заказали мотоцикл марки Ferrari. Время доставки ";
            str += t.ToString();
            str += " дней";
            return str;
        }
    }
    class Caramelo : Motorcycle {
        static Random rnd = new Random();
        int t = rnd.Next(15, 90);
        public override string Time() {
            string str = "Вы заказали мотоцикл модели Caramelo. Время доставки ";
            str += t.ToString();
            str += " дней";
            return str;
        }
    }
    abstract class Factory {
        public abstract Car createCar();
        public abstract Motorcycle createMotorcycle();
    }
    class Ferrari : Factory {
        public override Car createCar() {
            return new LaFerrari();
        }
        public override Motorcycle createMotorcycle() {
            return new MotoFer();
        }
    }
    class Lamborghini : Factory {
        public override Car createCar() {
            return new Sian();
        }
        public override Motorcycle createMotorcycle() {
            return new Caramelo();
        }
    }
    class Client {
        private Car car;
        private Motorcycle motorcycle;
        public Client(Factory factory) {
            car = factory.createCar();
            motorcycle = factory.createMotorcycle();
        }
        public string CarTime() {
            return car.Time();
        }
        public string MotoTime() {
            return motorcycle.Time();
        }
    }
}