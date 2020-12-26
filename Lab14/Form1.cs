using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            string str = textBox1.Text;
            TreeView trV = treeView1;
            Panel panel = new Panel();
            Tree tree = new Tree();
            panel.SetCommand(new TreeCommands(tree));
            panel.PressButtonDelete(str, trV);
            button1.Enabled = false;
            textBox1.Enabled = false;
            button2.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e) {
            string str = textBox2.Text;
            TreeView trV = treeView1;
            Panel panel = new Panel();
            Tree tree = new Tree();
            panel.SetCommand(new TreeCommands(tree));
            panel.PressButtonChange(str, trV);
            button2.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Text = "";
        }
    }
    interface Commands {
        void Add(string str, TreeView trV);
        void Undo(string str, TreeView trV);
    }
    class Tree {
        public void Change(string str, TreeView trV) {
            int amount = trV.Nodes[0].Nodes.Count;
            for (int i = 0; i < amount; ++i) {
                int amount1 = trV.Nodes[0].Nodes[0].Nodes.Count;
                for (int j = 0; j < amount1; ++j) {
                    if (trV.Nodes[0].Nodes[i].Nodes[j].Text == "") {
                        trV.Nodes[0].Nodes[i].Nodes[j].Text = str;
                    }
                }
            }
        }
        public void Delete(string str, TreeView trV) {
            int amount = trV.Nodes[0].Nodes.Count;
            for (int i = 0; i < amount; ++i) {
                int amount1 = trV.Nodes[0].Nodes[0].Nodes.Count;
                for (int j = 0; j < amount1; ++j) {
                    if (str == trV.Nodes[0].Nodes[i].Nodes[j].Text) {
                        trV.Nodes[0].Nodes[i].Nodes[j].Text = "";
                    }
                }
            }
        }
    }
    class TreeCommands : Commands {
        Tree tree;
        public TreeCommands(Tree treeSet) {
            tree = treeSet;
        }
        public void Add(string str, TreeView trV) {
            tree.Change(str, trV);
        }
        public void Undo(string str, TreeView trV) {
            tree.Delete(str, trV);
        }
    }
    class Panel {
        Commands command;
        public void SetCommand(Commands com) {
            command = com;
        }
        public void PressButtonChange(string str, TreeView trV) {
            if (command != null)
                command.Add(str, trV);
        }
        public void PressButtonDelete(string str, TreeView trV) {
            if (command != null)
                command.Undo(str, trV);
        }
    }
}