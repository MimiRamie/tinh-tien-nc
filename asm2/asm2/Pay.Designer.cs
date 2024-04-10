namespace asm2
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnEXIT = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 352);
            label1.Name = "label1";
            label1.Size = new Size(138, 38);
            label1.TabIndex = 1;
            label1.Text = "QR CODE";
            // 
            // btnEXIT
            // 
            btnEXIT.Location = new Point(257, 423);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(94, 50);
            btnEXIT.TabIndex = 2;
            btnEXIT.Text = "EXIT";
            btnEXIT.UseVisualStyleBackColor = true;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 497);
            Controls.Add(btnEXIT);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Pay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnEXIT;
    }
}