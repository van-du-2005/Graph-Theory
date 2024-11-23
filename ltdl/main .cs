namespace ltdl
{
    public partial class Form1 : Form
    {
        Dijkstra dijkstra = new Dijkstra(10);
        private int u, v, w;
        int x1, y1;
        int x2, y2;
        private List<LocationXY> locations = new List<LocationXY>();


        public Form1()
        {
            InitializeComponent();
            x1 = 100; y1 = 100;
            x2 = 1000; y2 = 1000;
            this.u = -1;
            this.v = -1;
            this.w = int.MaxValue;
            this.ptbQuocGia.Paint += new System.Windows.Forms.PaintEventHandler(this.PTBQuocGia_Paint);
        }

        private void reset()
        {
            this.u = -1;
            this.v = -1;
            this.w = int.MaxValue;
        }

        private void SaveVerticalClick()
        {
            InputWeight inputWeight = new InputWeight();
            if (u != -1 && v != -1)
            {
                inputWeight.ShowDialog();
                this.w = inputWeight.w;
                this.dijkstra.addEdges(this.u, this.v, this.w);
                reset();
                ptbQuocGia.Invalidate(); // Yêu cầu vẽ lại
            }
        }

        private void UpdateCoordinates(int countryId)
        {
            // Lấy vị trí chuột toàn cục
            Point mousePosition = Control.MousePosition;

            // Chuyển đổi tọa độ chuột từ không gian màn hình sang không gian của PictureBox
            Point clientPoint = ptbQuocGia.PointToClient(mousePosition);

            if (u != -1)
            {
                this.v = countryId;
                // Sử dụng clientPoint thay vì mousePosition để tính toán tọa độ trong PictureBox
                x2 = clientPoint.X; // Lưu tọa độ X trong không gian của PictureBox
                y2 = clientPoint.Y; // Lưu tọa độ Y trong không gian của PictureBox
                locations.Add(new LocationXY(x1, y1, x2, y2));
                SaveVerticalClick();
            }
            else
            {
                this.u = countryId;
                x1 = clientPoint.X; // Lưu tọa độ X trong không gian của PictureBox
                y1 = clientPoint.Y; // Lưu tọa độ Y trong không gian của PictureBox
            }
        }

        private void ptbThailand_Click(object sender, EventArgs e) { UpdateCoordinates(1); }
        private void ptbLao_Click(object sender, EventArgs e) { UpdateCoordinates(6); }
        private void ptbCampudia_Click(object sender, EventArgs e) { UpdateCoordinates(3); }
        private void ptbSingapore_Click(object sender, EventArgs e) { UpdateCoordinates(4); }
        private void ptbIndonesia_Click(object sender, EventArgs e) { UpdateCoordinates(5); }
        private void ptbMalaysia_Click(object sender, EventArgs e) { UpdateCoordinates(8); }
        private void ptbBrunei_Click(object sender, EventArgs e) { UpdateCoordinates(9); }
        private void ptbPhilippines_Click(object sender, EventArgs e) { UpdateCoordinates(0); }
        private void ptbMyanmar_Click(object sender, EventArgs e) { UpdateCoordinates(2); }

        private void ptbVietNam_Click(object sender, EventArgs e) { UpdateCoordinates(7); }
        private void button1_Click(object sender, EventArgs e)
        {
            dijkstra.result(0, 4);
            richTextBox1.Text = $"các quốc gia đi qua: {dijkstra._strPath}\nchi phí ít nhất phải trả: {dijkstra._strMoneyMin}";
        }

        private void PTBQuocGia_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Lặp qua danh sách và vẽ mỗi đường thẳng
            foreach (var line in locations)
            {
                // Tạo Pen với độ rộng và màu sắc mong muốn
                Pen pen = new Pen(Color.Black, 5);
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round; // Đầu đường tròn
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; // Cuối đường tròn

                // Vẽ đường thẳng từ (x1, y1) đến (x2, y2)
                g.DrawLine(pen, new Point(line.x1, line.y1), new Point(line.x2, line.y2));
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
