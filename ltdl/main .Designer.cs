namespace ltdl
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
            panel1 = new Panel();
            btnStartAndDestination = new Button();
            btnResult = new Button();
            richTextBox1 = new RichTextBox();
            ptbMyanmar = new PictureBox();
            ptbThailand = new PictureBox();
            ptbCampudia = new PictureBox();
            ptbSingapore = new PictureBox();
            ptbIndonesia = new PictureBox();
            ptbMalaysia = new PictureBox();
            ptbBrunei = new PictureBox();
            ptbPhilippines = new PictureBox();
            ptbLao = new PictureBox();
            ptbVietNam = new PictureBox();
            ptbQuocGia = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMyanmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbThailand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbCampudia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSingapore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbIndonesia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMalaysia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbBrunei).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPhilippines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbVietNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbQuocGia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnStartAndDestination);
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 736);
            panel1.TabIndex = 12;
            // 
            // btnStartAndDestination
            // 
            btnStartAndDestination.BackColor = Color.Silver;
            btnStartAndDestination.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartAndDestination.ForeColor = Color.Black;
            btnStartAndDestination.Location = new Point(3, 398);
            btnStartAndDestination.Name = "btnStartAndDestination";
            btnStartAndDestination.Size = new Size(169, 61);
            btnStartAndDestination.TabIndex = 56;
            btnStartAndDestination.Text = "chọn điểm xuất phát và điểm đến";
            btnStartAndDestination.UseVisualStyleBackColor = false;
            btnStartAndDestination.Click += btnStartAndDestination_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Silver;
            btnResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.ForeColor = Color.Black;
            btnResult.Location = new Point(3, 331);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(169, 61);
            btnResult.TabIndex = 0;
            btnResult.Text = "Tuyến đường có chi phí it nhất";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(169, 325);
            richTextBox1.TabIndex = 55;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // ptbMyanmar
            // 
            ptbMyanmar.Image = Properties.Resources.myanmar;
            ptbMyanmar.Location = new Point(282, 104);
            ptbMyanmar.Name = "ptbMyanmar";
            ptbMyanmar.Size = new Size(108, 66);
            ptbMyanmar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMyanmar.TabIndex = 52;
            ptbMyanmar.TabStop = false;
            ptbMyanmar.Click += ptbMyanmar_Click;
            // 
            // ptbThailand
            // 
            ptbThailand.Image = Properties.Resources.thaiLan;
            ptbThailand.Location = new Point(293, 244);
            ptbThailand.Name = "ptbThailand";
            ptbThailand.Size = new Size(108, 66);
            ptbThailand.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbThailand.TabIndex = 50;
            ptbThailand.TabStop = false;
            ptbThailand.Click += ptbThailand_Click;
            // 
            // ptbCampudia
            // 
            ptbCampudia.Image = Properties.Resources.campuchia;
            ptbCampudia.Location = new Point(389, 346);
            ptbCampudia.Name = "ptbCampudia";
            ptbCampudia.Size = new Size(108, 66);
            ptbCampudia.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCampudia.TabIndex = 51;
            ptbCampudia.TabStop = false;
            ptbCampudia.Click += ptbCampudia_Click;
            // 
            // ptbSingapore
            // 
            ptbSingapore.Image = Properties.Resources.singaporo;
            ptbSingapore.Location = new Point(351, 516);
            ptbSingapore.Name = "ptbSingapore";
            ptbSingapore.Size = new Size(113, 66);
            ptbSingapore.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSingapore.TabIndex = 56;
            ptbSingapore.TabStop = false;
            ptbSingapore.Click += ptbSingapore_Click;
            // 
            // ptbIndonesia
            // 
            ptbIndonesia.Image = Properties.Resources.indonesia;
            ptbIndonesia.Location = new Point(425, 633);
            ptbIndonesia.Name = "ptbIndonesia";
            ptbIndonesia.Size = new Size(108, 66);
            ptbIndonesia.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbIndonesia.TabIndex = 55;
            ptbIndonesia.TabStop = false;
            ptbIndonesia.Click += ptbIndonesia_Click;
            // 
            // ptbMalaysia
            // 
            ptbMalaysia.Image = Properties.Resources.malaysia;
            ptbMalaysia.Location = new Point(653, 435);
            ptbMalaysia.Name = "ptbMalaysia";
            ptbMalaysia.Size = new Size(108, 66);
            ptbMalaysia.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMalaysia.TabIndex = 54;
            ptbMalaysia.TabStop = false;
            ptbMalaysia.Click += ptbMalaysia_Click;
            // 
            // ptbBrunei
            // 
            ptbBrunei.Image = Properties.Resources.brunei;
            ptbBrunei.Location = new Point(933, 486);
            ptbBrunei.Name = "ptbBrunei";
            ptbBrunei.Size = new Size(108, 66);
            ptbBrunei.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbBrunei.TabIndex = 53;
            ptbBrunei.TabStop = false;
            ptbBrunei.Click += ptbBrunei_Click;
            // 
            // ptbPhilippines
            // 
            ptbPhilippines.Image = Properties.Resources.philipin;
            ptbPhilippines.Location = new Point(1031, 215);
            ptbPhilippines.Name = "ptbPhilippines";
            ptbPhilippines.Size = new Size(108, 66);
            ptbPhilippines.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPhilippines.TabIndex = 49;
            ptbPhilippines.TabStop = false;
            ptbPhilippines.Click += ptbPhilippines_Click;
            // 
            // ptbLao
            // 
            ptbLao.Image = Properties.Resources.lao;
            ptbLao.Location = new Point(733, 146);
            ptbLao.Name = "ptbLao";
            ptbLao.Size = new Size(108, 66);
            ptbLao.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLao.TabIndex = 48;
            ptbLao.TabStop = false;
            ptbLao.Click += ptbLao_Click;
            // 
            // ptbVietNam
            // 
            ptbVietNam.Image = Properties.Resources.VN;
            ptbVietNam.Location = new Point(759, 272);
            ptbVietNam.Name = "ptbVietNam";
            ptbVietNam.Size = new Size(108, 66);
            ptbVietNam.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbVietNam.TabIndex = 47;
            ptbVietNam.TabStop = false;
            ptbVietNam.Click += ptbVietNam_Click;
            // 
            // ptbQuocGia
            // 
            ptbQuocGia.Image = Properties.Resources.quocgia;
            ptbQuocGia.Location = new Point(179, 0);
            ptbQuocGia.Name = "ptbQuocGia";
            ptbQuocGia.Size = new Size(1007, 736);
            ptbQuocGia.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbQuocGia.TabIndex = 46;
            ptbQuocGia.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 735);
            Controls.Add(ptbMyanmar);
            Controls.Add(ptbThailand);
            Controls.Add(ptbCampudia);
            Controls.Add(ptbSingapore);
            Controls.Add(ptbIndonesia);
            Controls.Add(ptbMalaysia);
            Controls.Add(ptbBrunei);
            Controls.Add(ptbPhilippines);
            Controls.Add(ptbLao);
            Controls.Add(ptbVietNam);
            Controls.Add(ptbQuocGia);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbMyanmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbThailand).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbCampudia).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSingapore).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbIndonesia).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMalaysia).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbBrunei).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPhilippines).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLao).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbVietNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbQuocGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ptbMyanmar;
        private PictureBox ptbThailand;
        private PictureBox ptbCampudia;
        private PictureBox ptbSingapore;
        private PictureBox ptbIndonesia;
        private PictureBox ptbMalaysia;
        private PictureBox ptbBrunei;
        private PictureBox ptbPhilippines;
        private PictureBox ptbLao;
        private PictureBox ptbVietNam;
        private PictureBox ptbQuocGia;
        private Button btnResult;
        private RichTextBox richTextBox1;
        private Button btnStartAndDestination;
    }
}
