using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using X360;
using X360.IO;
using X360.Other;
using X360.Profile;
using X360.STFS;
using xPackage3.STFS;


namespace Absolute_Mods
{
    public partial class Signer : DevComponents.DotNetBar.Office2007Form
    {
        public Signer()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OFD1.ShowDialog();
            Package STFS = new Package(OFD1.FileName);
            textBoxX1.Text = STFS.ProfileID;
            textBoxX2.Text = STFS.DeviceID;
            textBoxX3.Text = STFS.ConsoleID;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                STFSPackage STFS = new STFSPackage(OFD1.FileName, null);
                STFS.FlushPackage(new RSAParams(Application.StartupPath + "\\KV.bin"));
                MessageBox.Show("Rehashed and Resigned");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Signer_Load(object sender, EventArgs e)
        {

        }


        }
    }

