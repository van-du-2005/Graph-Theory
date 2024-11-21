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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(41, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 0;
            button1.Text = "YES";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            richTextBox1.Location = new Point(141, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(220, 41);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 2;
            label1.Text = "Chi Phí";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(208, 83);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 3;
            button2.Text = "NO";
            button2.UseVisualStyleBackColor = false;
            // 
            // InputWeight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(373, 131);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            MinimizeBox = false;
            Name = "InputWeight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập Phí";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button2;
    }
}