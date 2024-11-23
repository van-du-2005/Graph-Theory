using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltdl
{
    public partial class StartAndDestinationSelection : Form
    {
        private int _istart, _iDestination;

        public int Start { get { return _istart; } }
        public int Destination { get { return _iDestination; } }

        public StartAndDestinationSelection()
        {

            _istart = -1; _iDestination = -1;
            InitializeComponent();
        }

        private void StartAndDestinationSelection_Load(object sender, EventArgs e)
        {

        }

        void selectStart()
        {
            if (rdbPhilipSt.Checked) _istart = 0;
            else if (rdbThaiSt.Checked) _istart = 1;
            else if (rdbMyanSt.Checked) _istart = 2;
            else if (rdbCamSt.Checked) _istart = 3;
            else if (rdbSinSt.Checked) _istart = 4;
            else if (rdbInSt.Checked) _istart = 5;
            else if (rdbLSt.Checked) _istart = 6;
            else if (rdbVNSt.Checked) _istart = 7;
            else if (rdbMalaySt.Checked) _istart = 8;
            else if (rdbBruSt.Checked) _istart = 9;

            
        }

        void selectDestinaton()
        {
            if (rdbPhilipDtnt.Checked) _iDestination = 0;
            else if (rdbThaiDtn.Checked) _iDestination = 1;
            else if (rdbMyanDtn.Checked) _iDestination = 2;
            else if (rdbCamDtn.Checked) _iDestination = 3;
            else if (rdbSinDtn.Checked) _iDestination = 4;
            else if (rdbInDtn.Checked) _iDestination = 5;
            else if (rdbLDtn.Checked) _iDestination = 6;
            else if (rdbVNDtn.Checked) _iDestination = 7;
            else if (rdbMalayDtn.Checked) _iDestination = 8;
            else if (rdbBruDtn.Checked) _iDestination = 9;

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            selectStart(); selectDestinaton();

            if(_istart == -1 || _iDestination == -1)
            {
                DialogResult result = MessageBox.Show(
                    "bạn chưa chọn điểm bắt đầu hoặc điểm đên cho chuyến đi bạn có chắc muốn thoát",
                    "Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes) Close();
            }
            else { Close(); } 
                
        }
    }
}
