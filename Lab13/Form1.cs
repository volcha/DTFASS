using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void radioButton1_Click(object sender, EventArgs e) {
            Receiver receiver = new Receiver(true, true, true);
            Handler surgeonHandler = new SurgeonHandler();
            Handler oculistHadler = new OculistHandler();
            Handler dentistHandler = new DentistHandler();
            surgeonHandler.Successor = oculistHadler;
            oculistHadler.Successor = dentistHandler;
            string str = "";
            surgeonHandler.Handle(receiver, str);
        }
        private void radioButton2_Click(object sender, EventArgs e) {
            Receiver receiver = new Receiver(false, true, true);
            Handler surgeonHandler = new SurgeonHandler();
            Handler oculistHadler = new OculistHandler();
            Handler dentistHandler = new DentistHandler();
            surgeonHandler.Successor = oculistHadler;
            oculistHadler.Successor = dentistHandler;
            string str = "";
            surgeonHandler.Handle(receiver, str);
        }
        private void radioButton3_Click(object sender, EventArgs e) {
            Receiver receiver = new Receiver(false, false, true);
            Handler surgeonHandler = new SurgeonHandler();
            Handler oculistHadler = new OculistHandler();
            Handler dentistHandler = new DentistHandler();
            surgeonHandler.Successor = oculistHadler;
            oculistHadler.Successor = dentistHandler;
            string str = "";
            surgeonHandler.Handle(receiver, str);
        }
        private void radioButton4_Click(object sender, EventArgs e) {
            Receiver receiver = new Receiver(false, false, false);
            Handler surgeonHandler = new SurgeonHandler();
            Handler oculistHadler = new OculistHandler();
            Handler dentistHandler = new DentistHandler();
            surgeonHandler.Successor = oculistHadler;
            oculistHadler.Successor = dentistHandler;
            string str = "";
            surgeonHandler.Handle(receiver, str);
        }
    }
    class Receiver {
        public bool surgeon { get; set; }
        public bool oculist { get; set; }
        public bool dentist { get; set; }
        public Receiver(bool sr, bool oc, bool de) {
            surgeon = sr;
            oculist = oc;
            dentist = de;
        }
    }
    abstract class Handler {
        public Handler Successor { get; set; }
        public abstract void Handle(Receiver receiver, string str);
    }
    class SurgeonHandler : Handler {
        public override void Handle(Receiver receiver, string str) {
            if (receiver.surgeon == true) {
                str += "Вам нужно к хирургу";
                MessageBox.Show(str);
            }
            else if (Successor != null) {
                str += "Вам не нужно к хирургу \n";
                Successor.Handle(receiver, str);
            }
        }
    }
    class OculistHandler : Handler {
        public override void Handle(Receiver receiver, string str) {
            if (receiver.oculist == true) {
                str += "Вам нужно к окулисту";
                MessageBox.Show(str);
            }
            else if (Successor != null) {
                str += "Вам не нужно к окулисту \n";
                Successor.Handle(receiver, str);
            }
        }
    }
    class DentistHandler : Handler {
        public override void Handle(Receiver receiver, string str) {
            if (receiver.dentist == true) {
                str += "Вам нужно к стомоматологу";
                MessageBox.Show(str);
            }
            else if (Successor != null) {
                Successor.Handle(receiver, str);
            }
            else {
                str += "Вам не нужно к окулисту \n";
                str += "Вы здоровы!";
                MessageBox.Show(str);
            }
        }
    }
}