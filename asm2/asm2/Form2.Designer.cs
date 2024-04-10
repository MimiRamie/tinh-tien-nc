namespace asm2
{
    partial class Form2
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
            btnCalc = new Button();
            txtThisMonth = new TextBox();
            txtLastMonth = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(636, 371);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 29);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "Calculate";
            btnCalc.TextAlign = ContentAlignment.BottomCenter;
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(316, 210);
            txtThisMonth.Multiline = true;
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(298, 53);
            txtThisMonth.TabIndex = 1;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(316, 300);
            txtLastMonth.Multiline = true;
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(298, 53);
            txtLastMonth.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 445);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(809, 125);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 213);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "This Month index";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 303);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 5;
            label2.Text = "Last Month index";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 445);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 766);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(txtLastMonth);
            Controls.Add(txtThisMonth);
            Controls.Add(btnCalc);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private TextBox txtThisMonth;
        private TextBox txtLastMonth;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}