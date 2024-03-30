namespace Calculator1
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt4 = new Button();
            bt5 = new Button();
            bt6 = new Button();
            bt9 = new Button();
            bt7 = new Button();
            bt8 = new Button();
            btmul = new Button();
            btdiv = new Button();
            btadd = new Button();
            btmin = new Button();
            bteq = new Button();
            lv1 = new ListView();
            btdel = new Button();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Location = new Point(632, 734);
            bt1.Name = "bt1";
            bt1.Size = new Size(150, 46);
            bt1.TabIndex = 1;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click_1;
            // 
            // bt2
            // 
            bt2.Location = new Point(347, 734);
            bt2.Name = "bt2";
            bt2.Size = new Size(150, 46);
            bt2.TabIndex = 2;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(41, 734);
            bt3.Name = "bt3";
            bt3.Size = new Size(150, 46);
            bt3.TabIndex = 3;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt4
            // 
            bt4.Location = new Point(632, 652);
            bt4.Name = "bt4";
            bt4.Size = new Size(150, 46);
            bt4.TabIndex = 4;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // bt5
            // 
            bt5.Location = new Point(347, 652);
            bt5.Name = "bt5";
            bt5.Size = new Size(150, 46);
            bt5.TabIndex = 5;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += bt5_Click;
            // 
            // bt6
            // 
            bt6.Location = new Point(41, 652);
            bt6.Name = "bt6";
            bt6.Size = new Size(150, 46);
            bt6.TabIndex = 6;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += bt6_Click;
            // 
            // bt9
            // 
            bt9.Location = new Point(41, 564);
            bt9.Name = "bt9";
            bt9.Size = new Size(150, 46);
            bt9.TabIndex = 7;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += bt9_Click;
            // 
            // bt7
            // 
            bt7.Location = new Point(632, 564);
            bt7.Name = "bt7";
            bt7.Size = new Size(150, 46);
            bt7.TabIndex = 7;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // bt8
            // 
            bt8.Location = new Point(347, 564);
            bt8.Name = "bt8";
            bt8.Size = new Size(150, 46);
            bt8.TabIndex = 8;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += bt8_Click;
            // 
            // btmul
            // 
            btmul.Location = new Point(632, 483);
            btmul.Name = "btmul";
            btmul.Size = new Size(150, 46);
            btmul.TabIndex = 9;
            btmul.Text = "*";
            btmul.UseVisualStyleBackColor = true;
            btmul.Click += btmul_Click;
            // 
            // btdiv
            // 
            btdiv.Location = new Point(347, 483);
            btdiv.Name = "btdiv";
            btdiv.Size = new Size(150, 46);
            btdiv.TabIndex = 10;
            btdiv.Text = "/";
            btdiv.UseVisualStyleBackColor = true;
            btdiv.Click += btdiv_Click;
            // 
            // btadd
            // 
            btadd.Location = new Point(41, 483);
            btadd.Name = "btadd";
            btadd.Size = new Size(150, 46);
            btadd.TabIndex = 11;
            btadd.Text = "+";
            btadd.UseVisualStyleBackColor = true;
            btadd.Click += btadd_Click;
            // 
            // btmin
            // 
            btmin.Location = new Point(632, 404);
            btmin.Name = "btmin";
            btmin.Size = new Size(150, 46);
            btmin.TabIndex = 14;
            btmin.Text = "-";
            btmin.UseVisualStyleBackColor = true;
            btmin.Click += btmin_Click;
            // 
            // bteq
            // 
            bteq.Location = new Point(347, 404);
            bteq.Name = "bteq";
            bteq.Size = new Size(150, 46);
            bteq.TabIndex = 15;
            bteq.Text = "=";
            bteq.UseVisualStyleBackColor = true;
            bteq.Click += bteq_Click;
            // 
            // lv1
            // 
            lv1.Location = new Point(41, 37);
            lv1.Name = "lv1";
            lv1.Size = new Size(741, 327);
            lv1.TabIndex = 16;
            lv1.UseCompatibleStateImageBehavior = false;
            lv1.SelectedIndexChanged += lv1_SelectedIndexChanged;
            // 
            // btdel
            // 
            btdel.Location = new Point(41, 404);
            btdel.Name = "btdel";
            btdel.Size = new Size(150, 46);
            btdel.TabIndex = 17;
            btdel.Text = "DEL";
            btdel.UseVisualStyleBackColor = true;
            btdel.Click += btdel_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 865);
            Controls.Add(btdel);
            Controls.Add(lv1);
            Controls.Add(bteq);
            Controls.Add(btmin);
            Controls.Add(btadd);
            Controls.Add(btdiv);
            Controls.Add(btmul);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(bt9);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Name = "MainForm";
            Text = "Calculator1";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button bt5;
        private Button bt6;
        private Button bt9;
        private Button bt7;
        private Button bt8;
        private Button btmul;
        private Button btdiv;
        private Button btadd;
        private Button btmin;
        private Button bteq;
        private ListView lv1;
        private Button btdel;
    }
}