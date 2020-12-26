namespace Lab14 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Великие озёра");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ванкувер");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Банф");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Канада", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Париж");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Шамони");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ницца");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Франция", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Токио");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Киото");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Фудзияма");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Япония", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Достопримечательности", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел2";
            treeNode1.Text = "Великие озёра";
            treeNode2.Name = "Узел3";
            treeNode2.Text = "Ванкувер";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "Банф";
            treeNode4.Name = "Узел1";
            treeNode4.Text = "Канада";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "Париж";
            treeNode6.Name = "Узел7";
            treeNode6.Text = "Шамони";
            treeNode7.Name = "Узел8";
            treeNode7.Text = "Ницца";
            treeNode8.Name = "Узел5";
            treeNode8.Text = "Франция";
            treeNode9.Name = "Узел10";
            treeNode9.Text = "Токио";
            treeNode10.Name = "Узел11";
            treeNode10.Text = "Киото";
            treeNode11.Name = "Узел12";
            treeNode11.Text = "Фудзияма";
            treeNode12.Name = "Узел9";
            treeNode12.Text = "Япония";
            treeNode13.Name = "Узел0";
            treeNode13.Text = "Достопримечательности";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(173, 228);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Уже был в ...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить из списка желаний";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Теперь хочу посетить ... в этой стране";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(206, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(248, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить в список желаний";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}