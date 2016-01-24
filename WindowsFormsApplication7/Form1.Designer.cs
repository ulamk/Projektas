namespace WindowsFormsApplication7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.MaskedTextBox();
            this.mg = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.MaskedTextBox();
            this.input2 = new System.Windows.Forms.MaskedTextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlk = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "skaicius";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(12, 212);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(100, 20);
            this.rez.TabIndex = 1;
            // 
            // mg
            // 
            this.mg.Location = new System.Drawing.Point(177, 209);
            this.mg.Name = "mg";
            this.mg.Size = new System.Drawing.Size(75, 23);
            this.mg.TabIndex = 2;
            this.mg.Text = "button1";
            this.mg.UseVisualStyleBackColor = true;
            this.mg.Click += new System.EventHandler(this.mg_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 28);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(152, 28);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 4;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(13, 12);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(25, 13);
            this.l2.TabIndex = 5;
            this.l2.Text = "nuo";
            this.l2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "iki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "dalikliai";
            // 
            // dlk
            // 
            this.dlk.Location = new System.Drawing.Point(13, 87);
            this.dlk.Name = "dlk";
            this.dlk.Size = new System.Drawing.Size(100, 20);
            this.dlk.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(152, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dlk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.mg);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox rez;
        private System.Windows.Forms.Button mg;
        private System.Windows.Forms.MaskedTextBox input1;
        private System.Windows.Forms.MaskedTextBox input2;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dlk;
        private System.Windows.Forms.ListBox listBox1;
    }
}

