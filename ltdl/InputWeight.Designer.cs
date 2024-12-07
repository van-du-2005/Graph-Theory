namespace ltdl
{
    partial class InputWeight
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
            button1 = new Button();
            textChiPhi = new RichTextBox();
            label1 = new Label();
            button2 = new Button();
            ptbTru = new PictureBox();
            ptbCong = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbTru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbCong).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(66, 97);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 0;
            button1.Text = "YES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textChiPhi
            // 
            textChiPhi.BackColor = Color.White;
            textChiPhi.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            textChiPhi.Location = new Point(66, 50);
            textChiPhi.Name = "textChiPhi";
            textChiPhi.Size = new Size(220, 41);
            textChiPhi.TabIndex = 1;
            textChiPhi.Text = "0";
            textChiPhi.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(220, 27);
            label1.TabIndex = 2;
            label1.Text = "Mời bạn nhập chi phí:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(192, 97);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 3;
            button2.Text = "NO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ptbTru
            // 
            ptbTru.BackColor = Color.White;
            ptbTru.Image = Properties.Resources.tru;
            ptbTru.Location = new Point(12, 50);
            ptbTru.Name = "ptbTru";
            ptbTru.Size = new Size(42, 41);
            ptbTru.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbTru.TabIndex = 4;
            ptbTru.TabStop = false;
            ptbTru.Click += ptbTru_Click;
            // 
            // ptbCong
            // 
            ptbCong.BackColor = Color.White;
            ptbCong.Image = Properties.Resources.cong;
            ptbCong.Location = new Point(292, 50);
            ptbCong.Name = "ptbCong";
            ptbCong.Size = new Size(42, 41);
            ptbCong.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCong.TabIndex = 5;
            ptbCong.TabStop = false;
            ptbCong.Click += ptbCong_Click;
            // 
            // InputWeight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 153);
            Controls.Add(ptbCong);
            Controls.Add(ptbTru);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textChiPhi);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputWeight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập Chi Phí";
            Load += InputWeight_Load;
            ((System.ComponentModel.ISupportInitialize)ptbTru).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbCong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox textChiPhi;
        private Label label1;
        private Button button2;
        private PictureBox ptbTru;
        private PictureBox ptbCong;
    }
}