using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PropertiesSettings : UserControl
    {
        public PropertiesSettings()
        {
            InitializeComponent();
        }

        public int Result 
        {
            get { return GetChecked(); }
        }

        private void _radioAsc_CheckedChanged(object sender, EventArgs e)
        {
            _radioDesc.Checked = !_radioAsc.Checked;
        }

        private int GetChecked() 
        {
            if (_radioAsc.Checked)
                return 0;
            return 1;
        }

        private void PropertiesSettings_Load(object sender, EventArgs e)
        {
            _radioAsc.Checked = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _radioDesc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
