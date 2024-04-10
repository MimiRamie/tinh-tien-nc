namespace asm2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtNameCus = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtFamMem = new TextBox();
            label4 = new Label();
            btnCalc = new Button();
            btnExit = new Button();
            comTypeCus = new ComboBox();
            txtThisMonth = new TextBox();
            txtLastMonth = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtResult = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtConsump = new TextBox();
            btnClear = new Button();
            lv = new ListView();
            txtSave = new Button();
            label9 = new Label();
            btnPay = new Button();
            label10 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnDel = new Button();
            btnUp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(472, 35);
            label1.Name = "label1";
            label1.Size = new Size(337, 33);
            label1.TabIndex = 4;
            label1.Text = "WATER BILL CACULATOR";
            // 
            // txtNameCus
            // 
            txtNameCus.Location = new Point(91, 158);
            txtNameCus.Name = "txtNameCus";
            txtNameCus.Size = new Size(298, 27);
            txtNameCus.TabIndex = 5;
            txtNameCus.TextChanged += txtNameCus_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 119);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 6;
            label2.Text = "NAME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 212);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 8;
            label3.Text = "Type of Customer";
            // 
            // txtFamMem
            // 
            txtFamMem.Enabled = false;
            txtFamMem.Location = new Point(91, 346);
            txtFamMem.Name = "txtFamMem";
            txtFamMem.Size = new Size(66, 27);
            txtFamMem.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 305);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 11;
            label4.Text = "Family Members ";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(791, 202);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(96, 41);
            btnCalc.TabIndex = 12;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.TextChanged += btnCalc_TextChanged;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1075, 624);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 75);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // comTypeCus
            // 
            comTypeCus.FormattingEnabled = true;
            comTypeCus.Items.AddRange(new object[] { "Household ", "Administative agency or public service ", "Production unit", "Business services" });
            comTypeCus.Location = new Point(91, 252);
            comTypeCus.Name = "comTypeCus";
            comTypeCus.Size = new Size(298, 28);
            comTypeCus.TabIndex = 14;
            comTypeCus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtThisMonth
            // 
            txtThisMonth.Location = new Point(540, 158);
            txtThisMonth.Name = "txtThisMonth";
            txtThisMonth.Size = new Size(202, 27);
            txtThisMonth.TabIndex = 15;
            txtThisMonth.TextChanged += txtThisMonth_TextChanged;
            // 
            // txtLastMonth
            // 
            txtLastMonth.Location = new Point(540, 252);
            txtLastMonth.Name = "txtLastMonth";
            txtLastMonth.Size = new Size(202, 27);
            txtLastMonth.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 119);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 17;
            label5.Text = "This Month index";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 211);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 18;
            label6.Text = "Last Month index";
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Location = new Point(943, 158);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(165, 27);
            txtResult.TabIndex = 19;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(943, 119);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 20;
            label7.Text = "Money";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(943, 212);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 21;
            label8.Text = "Consumption";
            label8.Click += label8_Click;
            // 
            // txtConsump
            // 
            txtConsump.Enabled = false;
            txtConsump.Location = new Point(943, 253);
            txtConsump.Name = "txtConsump";
            txtConsump.Size = new Size(165, 27);
            txtConsump.TabIndex = 22;
            txtConsump.TextChanged += txtConsump_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1012, 332);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 41);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lv
            // 
            lv.Location = new Point(12, 405);
            lv.Name = "lv";
            lv.Size = new Size(813, 348);
            lv.TabIndex = 24;
            lv.UseCompatibleStateImageBehavior = false;
            lv.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // txtSave
            // 
            txtSave.Enabled = false;
            txtSave.Location = new Point(888, 332);
            txtSave.Name = "txtSave";
            txtSave.Size = new Size(96, 41);
            txtSave.TabIndex = 25;
            txtSave.Text = "Save";
            txtSave.UseVisualStyleBackColor = true;
            txtSave.Click += txtSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1116, 161);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 26;
            label9.Text = "(VND)";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(888, 624);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(139, 75);
            btnPay.TabIndex = 27;
            btnPay.Text = "Pay now";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1116, 256);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 28;
            label10.Text = "(W/P)";
            // 
            // button1
            // 
            button1.Location = new Point(1128, 332);
            button1.Name = "button1";
            button1.Size = new Size(96, 41);
            button1.TabIndex = 29;
            button1.Text = "Price";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(943, 405);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(715, 370);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 31;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click_1;
            // 
            // btnUp
            // 
            btnUp.Enabled = false;
            btnUp.Location = new Point(604, 370);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(94, 29);
            btnUp.TabIndex = 32;
            btnUp.Text = "Update";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 765);
            Controls.Add(btnUp);
            Controls.Add(btnDel);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(btnPay);
            Controls.Add(label9);
            Controls.Add(txtSave);
            Controls.Add(lv);
            Controls.Add(btnClear);
            Controls.Add(txtConsump);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtResult);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLastMonth);
            Controls.Add(txtThisMonth);
            Controls.Add(comTypeCus);
            Controls.Add(btnExit);
            Controls.Add(btnCalc);
            Controls.Add(txtFamMem);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtNameCus);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "WaterBill";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNameCus;
        private Label label2;
        private Label label3;
        private TextBox txtFamMem;
        private Label label4;
        private Button btnCalc;
        private Button btnExit;
        private ComboBox comTypeCus;
        private TextBox txtThisMonth;
        private TextBox txtLastMonth;
        private Label label5;
        private Label label6;
        private TextBox txtResult;
        private Label label7;
        private Label label8;
        private TextBox txtConsump;
        private Button btnClear;
        private ListView lv;
        private Button txtSave;
        private Label label9;
        private Button btnPay;
        private Label label10;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnDel;
        private Button btnUp;
    }
}
