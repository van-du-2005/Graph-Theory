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
        public int w;
        public InputWeight()
        {
            InitializeComponent();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.w = int.Parse(textChiPhi.Text);
            this.Close();

        }

        private void InputWeight_Load(object sender, EventArgs e)
        {

        }
    }
}
