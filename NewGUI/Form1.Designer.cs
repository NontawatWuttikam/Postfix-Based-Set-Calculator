namespace NewGUI
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
            this.SetValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertSetButt = new System.Windows.Forms.Button();
            this.InfixBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateButt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteBox = new System.Windows.Forms.TextBox();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UnionRad = new System.Windows.Forms.RadioButton();
            this.PowerSetRad = new System.Windows.Forms.RadioButton();
            this.CartesianRad = new System.Windows.Forms.RadioButton();
            this.SubSetRad = new System.Windows.Forms.RadioButton();
            this.NotifLabel = new System.Windows.Forms.Label();
            this.ClearResultButt = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SetValue
            // 
            this.SetValue.Location = new System.Drawing.Point(178, 9);
            this.SetValue.Name = "SetValue";
            this.SetValue.Size = new System.Drawing.Size(178, 20);
            this.SetValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert Set [A-K]";
            // 
            // SetName
            // 
            this.SetName.Location = new System.Drawing.Point(96, 9);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(36, 20);
            this.SetName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // InsertSetButt
            // 
            this.InsertSetButt.Location = new System.Drawing.Point(362, 6);
            this.InsertSetButt.Name = "InsertSetButt";
            this.InsertSetButt.Size = new System.Drawing.Size(56, 23);
            this.InsertSetButt.TabIndex = 4;
            this.InsertSetButt.Text = "OK";
            this.InsertSetButt.UseVisualStyleBackColor = true;
            this.InsertSetButt.Click += new System.EventHandler(this.InsertSetButt_Click);
            // 
            // InfixBox
            // 
            this.InfixBox.Location = new System.Drawing.Point(54, 61);
            this.InfixBox.Name = "InfixBox";
            this.InfixBox.Size = new System.Drawing.Size(178, 20);
            this.InfixBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "exp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Union, Intersection,Diff (A U B n C) - C";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CalculateButt
            // 
            this.CalculateButt.Location = new System.Drawing.Point(238, 59);
            this.CalculateButt.Name = "CalculateButt";
            this.CalculateButt.Size = new System.Drawing.Size(56, 23);
            this.CalculateButt.TabIndex = 8;
            this.CalculateButt.Text = "Calculate";
            this.CalculateButt.UseVisualStyleBackColor = true;
            this.CalculateButt.Click += new System.EventHandler(this.CalculateButt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result";
            // 
            // DeleteBox
            // 
            this.DeleteBox.Location = new System.Drawing.Point(96, 34);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(56, 20);
            this.DeleteBox.TabIndex = 12;
            // 
            // DeleteButt
            // 
            this.DeleteButt.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButt.Location = new System.Drawing.Point(12, 32);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(76, 23);
            this.DeleteButt.TabIndex = 13;
            this.DeleteButt.Text = "Delete Set";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Power Set P(AUB) (no P() needed)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cartesian Product AxB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Subset A c B";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // UnionRad
            // 
            this.UnionRad.AutoSize = true;
            this.UnionRad.Location = new System.Drawing.Point(54, 87);
            this.UnionRad.Name = "UnionRad";
            this.UnionRad.Size = new System.Drawing.Size(14, 13);
            this.UnionRad.TabIndex = 17;
            this.UnionRad.TabStop = true;
            this.UnionRad.UseVisualStyleBackColor = true;
            // 
            // PowerSetRad
            // 
            this.PowerSetRad.AutoSize = true;
            this.PowerSetRad.Location = new System.Drawing.Point(54, 106);
            this.PowerSetRad.Name = "PowerSetRad";
            this.PowerSetRad.Size = new System.Drawing.Size(14, 13);
            this.PowerSetRad.TabIndex = 18;
            this.PowerSetRad.TabStop = true;
            this.PowerSetRad.UseVisualStyleBackColor = true;
            // 
            // CartesianRad
            // 
            this.CartesianRad.AutoSize = true;
            this.CartesianRad.Location = new System.Drawing.Point(54, 126);
            this.CartesianRad.Name = "CartesianRad";
            this.CartesianRad.Size = new System.Drawing.Size(14, 13);
            this.CartesianRad.TabIndex = 19;
            this.CartesianRad.TabStop = true;
            this.CartesianRad.UseVisualStyleBackColor = true;
            // 
            // SubSetRad
            // 
            this.SubSetRad.AutoSize = true;
            this.SubSetRad.Location = new System.Drawing.Point(54, 145);
            this.SubSetRad.Name = "SubSetRad";
            this.SubSetRad.Size = new System.Drawing.Size(14, 13);
            this.SubSetRad.TabIndex = 20;
            this.SubSetRad.TabStop = true;
            this.SubSetRad.UseVisualStyleBackColor = true;
            // 
            // NotifLabel
            // 
            this.NotifLabel.AutoSize = true;
            this.NotifLabel.Location = new System.Drawing.Point(175, 34);
            this.NotifLabel.Name = "NotifLabel";
            this.NotifLabel.Size = new System.Drawing.Size(13, 13);
            this.NotifLabel.TabIndex = 21;
            this.NotifLabel.Text = ":)";
            // 
            // ClearResultButt
            // 
            this.ClearResultButt.Location = new System.Drawing.Point(362, 29);
            this.ClearResultButt.Name = "ClearResultButt";
            this.ClearResultButt.Size = new System.Drawing.Size(56, 23);
            this.ClearResultButt.TabIndex = 22;
            this.ClearResultButt.Text = "Clear";
            this.ClearResultButt.UseVisualStyleBackColor = true;
            this.ClearResultButt.Click += new System.EventHandler(this.ClearResultButt_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(52, 171);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(366, 66);
            this.ResultBox.TabIndex = 23;
            this.ResultBox.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(301, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 249);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ClearResultButt);
            this.Controls.Add(this.NotifLabel);
            this.Controls.Add(this.SubSetRad);
            this.Controls.Add(this.CartesianRad);
            this.Controls.Add(this.PowerSetRad);
            this.Controls.Add(this.UnionRad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.DeleteBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalculateButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfixBox);
            this.Controls.Add(this.InsertSetButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetValue);
            this.Name = "Form1";
            this.Text = "Set Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SetValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InsertSetButt;
        private System.Windows.Forms.TextBox InfixBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateButt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteSet;
        private System.Windows.Forms.TextBox DeleteBox;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton UnionRad;
        private System.Windows.Forms.RadioButton PowerSetRad;
        private System.Windows.Forms.RadioButton CartesianRad;
        private System.Windows.Forms.RadioButton SubSetRad;
        private System.Windows.Forms.Label NotifLabel;
        private System.Windows.Forms.Button ClearResultButt;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

