using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVS_DiskUP;
using PVS_DiskUP.Properties;

namespace PVS_DiskUP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var stream = ofd.OpenFile();
                var header = stream.ReadStructure<VDISK_HEADER>();
                var footer = stream.ReadStructure<VDISK_FOOTER>();
                if (header == null || footer == null)
                {
                    MessageBox.Show(Resources.ReadPVPFailureText);
                }
                else
                {
                    propertyGrid1.SelectedObject = new VDISK_HEADER_WRAPPER(header.Value);
                    propertyGrid1.Text = Resources.HeaderTitle;

                    propertyGrid2.SelectedObject = new VDISK_FOOTER_WRAPPER(footer.Value);
                    propertyGrid2.Text = Resources.FooterTitle;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
