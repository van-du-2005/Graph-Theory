namespace ltdl
{
    public partial class Form1 : Form
    {
        Dijkstra dijkstra = new Dijkstra(10);
        private int u, v, w;

        public Form1()
        {
            InitializeComponent();
            this.u = -1;
            this.v = -1;
            this.w = int.MaxValue;
        }
        private void reset()
        {
            this.u = -1;
            this.v = -1;
            this.w = int.MaxValue;
        }
        private void SaveVerticalClick()
        {
            // Tạo form InputWeight
            InputWeight inputWeight = new InputWeight();
            if (u != -1 && v != -1)
            {
                inputWeight.ShowDialog();
                this.w = inputWeight.w;

                this.dijkstra.addEdges(this.u, this.v, this.w);
                reset();

            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ptbThailand_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ptbMyanmar_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 1;
                SaveVerticalClick();
            }
            else this.u = 1;

        }

        private void ptbQuocGia_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 2;
                SaveVerticalClick();
            }
            else this.u = 2;

        }

        private void ptbLao_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 6;
                SaveVerticalClick();
            }
            else this.u = 6;

        }

        private void ptbCampudia_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 3;
                SaveVerticalClick();
            }
            else this.u = 3;

        }

        private void ptbSingapore_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 4;
                SaveVerticalClick();
            }
            else this.u = 4;

        }

        private void ptbIndonesia_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 5;
                SaveVerticalClick();
            }
            else this.u = 5;

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 7;
                SaveVerticalClick();
            }
            else this.u = 7;

        }

        private void ptbMalaysia_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 8;
                SaveVerticalClick();
            }
            else this.u = 8;

        }

        private void ptbBrunei_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 9;
                SaveVerticalClick();
            }
            else this.u = 9;

        }

        private void ptbPhilippines_Click(object sender, EventArgs e)
        {
            if (u != -1)
            {
                this.v = 0;
                SaveVerticalClick();
            }
            else this.u = 0;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
