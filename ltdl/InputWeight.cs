using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltdl
{
    public partial class InputWeight : Form
    {
        public int w, ok;
        public InputWeight()
        {
            InitializeComponent();
            ok = 0;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chiPhi = 0;
            if (int.TryParse(textChiPhi.Text, out chiPhi))
            {
                this.w = chiPhi;
                ok = 1;
                this.Close();
            }
            else MessageBox.Show("chí phí chỉ nhập số không nhập chữ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void InputWeight_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ok = 0;
            Close();
        }

        private void ptbTru_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(textChiPhi.Text, out num))
            {
                if(num > 0)
                {
                    num -= 1;
                    textChiPhi.Text = num.ToString();
                }    
            }

        }

        private void ptbCong_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(textChiPhi.Text, out num))
            {
                num += 1;
                textChiPhi.Text = num.ToString();
            }

        }
    }
}
